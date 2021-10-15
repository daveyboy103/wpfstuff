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
            await webClient.PutAsJsonAsync("api/Wpf/WpfTest/Apply", model);
        }

        public  MainWindowModel Get(int id)
        {
            var webClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44342/")
            };

            var ret = webClient.GetFromJsonAsync<MainWindowModel>($"api/Wpf/WpfTest?id={id}");

            return ret.Result;
        }
    }
}
