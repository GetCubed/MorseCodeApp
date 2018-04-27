using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using PaddlePlusPlus.Models;
using PaddlePlusPlus.Utilities;

namespace PaddlePlusPlus.DAL
{
    class MorseCodeRespository: IMorseCodeRepository
    {
        HttpClient client = new HttpClient();

        public MorseCodeRespository()
        {
            client.BaseAddress = Jeeves.DBUri;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<MorseCode> EncodeByStringAsync(string text)
        {
            var response = await client.GetAsync($"encode?string={text}");

            if (response.IsSuccessStatusCode)
            {
                MorseCode morseCode = await response.Content.ReadAsAsync<MorseCode>();
                return morseCode;
            }
            else
            {
                return new MorseCode();
            }
        }

 
    }
}
