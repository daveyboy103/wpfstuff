using System;
using System.Net.Http;
using System.Net.Http.Json;
using WpfModels.Models;

namespace SampleWPF.Data
{
    public class SampleDataService : ISampleDataService
    {
        private const string UriString = "https://localhost:5001/";

        public async void Apply(MainWindowModel model)
        {
            var webClient = new HttpClient
            {
                BaseAddress = new Uri(UriString)
            };

            //await webClient.PostFromJsonAsync("/WpfTest/Apply", new HttpContent();
            await webClient.PutAsJsonAsync("api/Wpf/WpfTest/Apply", model);
        }

        public  MainWindowModel Get(int id)
        {
            var webClient = new HttpClient
            {
                BaseAddress = new Uri(UriString)
            };

            var ret = webClient.GetFromJsonAsync<MainWindowModel>($"api/Wpf/WpfTest?id={id}");

            return ret.Result;
        }
    }
}
