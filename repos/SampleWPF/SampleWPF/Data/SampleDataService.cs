using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WpfModels.Models;

namespace SampleWPF.Data
{
    public class SampleDataService : ISampleDataService
    {
        public async void Apply(MainWindowModel model)
        {
            var webClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44342/")
            };

            //await webClient.PostFromJsonAsync("/WpfTest/Apply", new HttpContent();
            await webClient.PutAsJsonAsync("/WpfTest/Apply", model);
        }

        public async Task<MainWindow> Get(int id)
        {
            var webClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44342/")
            };

            return await webClient.GetFromJsonAsync<MainWindow>($"/WpfTest?id={id}");
        }
    }
}
