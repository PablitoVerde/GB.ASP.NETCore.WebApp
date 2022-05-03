﻿using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;
using Timesheets.DAL.Entities;
using Timesheets.DAL.Repository;
using Timesheets.DAL.Repository.Interfaces;

namespace Timesheets.Services
{
    public class ContractService : IService<ContractDto>
    {
        private readonly IContractRepository _contractRepository;
        private readonly IMapper _mapper;

        public ContractService(IContractRepository contractRepository, IMapper mapper)
        {
            _contractRepository = contractRepository;
            _mapper = mapper;
        }

        public async Task Create(ContractDto item)
        {
            var contract = new ContractEntity
            {
                Name = item.Name,
                Description = item.Description,
                Invoice = new InvoiceEntity($"Invoice for {item.Name}"),
            };

            await _contractRepository.Add(contract);
        }

        public async Task Delete(int id)
        {
            var contract = await _contractRepository.Get(id);

            contract.Delete();

            await _contractRepository.Delete(contract);

        }

        public async Task<ContractDto> Get(int id)
        {
            var contract = await _contractRepository.Get(id);
            return _mapper.Map<ContractDto>(contract);
        }

        public async Task<IList<ContractEntity>> GetAll()
        {
            var allcontracts = await _contractRepository.GetAll();
            return (IList<ContractEntity>)allcontracts;
        }

        public async Task Update(ContractDto item)
        {
            var contract = await _contractRepository.Get(item.Id);
            contract.Name = item.Name;
            contract.Description = item.Description;
            await _contractRepository.Update(contract);
        }
    }
}
