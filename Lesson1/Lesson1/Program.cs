using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            string FilePath = Directory.GetCurrentDirectory() + @"\result.txt";

            Task[] tasks = new Task[10];

            for (int i = 4; i <= 13; i++)
            {
                Task task = GetMessageById(i);

                tasks[i - 4] = task;
            }

            Task.WaitAll(tasks);

            foreach(Task<BlogMessage> v in tasks)
            {
                StreamWriter sw = new StreamWriter(FilePath,true);

                sw.WriteLine(v.Result.userId);
                sw.WriteLine(v.Result.id);
                sw.WriteLine(v.Result.title);
                sw.WriteLine(v.Result.body);
                sw.WriteLine();

                sw.Close();
            }

            Console.WriteLine("End");

            Console.ReadKey();

            async Task<BlogMessage> GetMessageById(int id)
            {
                HttpClient http = new HttpClient();

                var response = await http.GetAsync("https://jsonplaceholder.typicode.com/posts/" + id);
                var json = await response.Content.ReadAsStringAsync();

                BlogMessage message = JsonSerializer.Deserialize<BlogMessage>(json);

                return message;
            }
        }
    }
}
