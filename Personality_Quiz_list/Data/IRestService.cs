using System;
using System.Threading.Tasks;

namespace Personality_Quiz_list.Data
{
    public interface IRestService
    {
        Task<string> GetCharacter(string characterName);
    }
}
