using System;
using System.Threading.Tasks;

namespace Personality_Quiz_list.Data
{
    public class StarWarsManager
    {
        IRestService restService;
        public StarWarsManager(IRestService service)
        {
            restService = service;
        }

        public Task<string> GetCharacter(string characterName)
        {
            return restService.GetCharacter(characterName);

        }
    }
}
