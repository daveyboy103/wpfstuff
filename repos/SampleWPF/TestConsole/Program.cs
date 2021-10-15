using System;
using System.Net.Http;
using System.Net.Http.Json;
using WpfModels.Models;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();

            Console.WriteLine("Waiting...");
            Console.ReadKey();
        }

        private async static void Run()
        {
            var webClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44342/")
            };

            var ret = await webClient.GetFromJsonAsync<MainWindowModel>($"api/Wpf/WpfTest?id={1}");

            Console.WriteLine(ret.Description);
            Console.ReadKey();
        }
    }
}
