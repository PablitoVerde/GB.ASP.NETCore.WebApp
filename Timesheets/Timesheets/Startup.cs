using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.DAL.Repository.Interfaces;
using Timesheets.DAL.Repository;
using Timesheets.DAL.Entities;
using Microsoft.Extensions.DependencyInjection.Extensions;
using AutoMapper;
using Timesheets.Mapper;

namespace Timesheets
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var mapper = new MapperConfiguration(mapper => mapper.AddProfile(new MapperProfile())).CreateMapper();
            services.AddSingleton(mapper);
            
            services.AddControllers();

            services.TryAddTransient<IContractRepository, ContractRepository>();
            services.TryAddTransient<ICustomerRepository, CustomerRepository>();
            services.TryAddTransient<IEmployeeRepository, EmployeeRepository>();
            services.TryAddTransient<IInvoiceRepository, InvoiceRepository>();
            services.TryAddTransient<ITaskRepository, TaskRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
