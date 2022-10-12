using PokeApiNet;
using System.Threading.Tasks;

namespace Pokemon_Drawing_Prompt.Services.Interfaces
{
    public interface IPokemonApiClient
    {
        Task<Pokemon> GetRandomPokemon();
    }
}