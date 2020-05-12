using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Personality_Quiz_list;


namespace Personality_Quiz_list.Data
{
    public class RestService : IRestService
    {
        HttpClient _client;
        string CharacterName { get; set; }
        


        public RestService()
        {
            _client = new HttpClient();


        }

        public async Task<string> GetCharacter(string characterName)
        {
           
            var uri = new Uri(string.Format(Constants.StarWarsUrl + characterName, string.Empty));
            

            try
            {
                var response = await _client.GetAsync(uri);
                Debug.WriteLine("XXXX" + response.ToString());
                if (response.IsSuccessStatusCode)
                {

                    var content = await response.Content.ReadAsStringAsync();

                    var character = (JObject)JsonConvert.DeserializeObject(content);

                    string[] name = character["results"].Select(x => (string)x["name"]).ToArray();
                    CharacterName = name[0];
                    

                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return CharacterName;
        }
    }
}
