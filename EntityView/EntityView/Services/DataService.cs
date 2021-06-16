using EntityView.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EntityView.Services
{
    public static class DataService
    {
        public static List<T> GetAll<T>(string api_path)
        {
            using(var Http = new HttpClient() { BaseAddress = new Uri("https://localhost:44386/api/") })
            {
                var response = Http.GetAsync(api_path).Result;

                if (response.IsSuccessStatusCode)
                {
                    var jsonContent = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<T>>(jsonContent);
                }
            }
            return null;
        }


        public static T Get<T>(string api_path)
        {
            using (var Http = new HttpClient() { BaseAddress = new Uri("https://localhost:44386/api/") })
            {
                var response = Http.GetAsync(api_path).Result;

                if (response.IsSuccessStatusCode)
                {
                    var jsonContent = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<T>(jsonContent);
                }
            }

            return default(T);
        }

    }
}
