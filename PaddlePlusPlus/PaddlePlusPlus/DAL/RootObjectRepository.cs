using PaddlePlusPlus.Models;
using PaddlePlusPlus.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PaddlePlusPlus.DAL
{
    class RootObjectRepository : IRootObjectRepository
    {
        HttpClient client = new HttpClient();

        public RootObjectRepository()
        {
            client.BaseAddress = Jeeves.DBUri;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Rootobject> GetRootObjectByTextAsync(string text, string speed, string tone)
        {
            var response = await client.GetAsync($"translate/morse/audio.json?text={text}&speed={speed}&tone={tone}");

            if (response.IsSuccessStatusCode)
            {
                Rootobject Rootobject = await response.Content.ReadAsAsync<Rootobject>();
                return Rootobject;
            }
            else
            {
                return new Rootobject();
            }




        }
    }
}
