using PokeApiNet;
using Pokemon_Drawing_Prompt.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace Pokemon_Drawing_Prompt.Services
{
    public class PokemonApiClient : IPokemonApiClient
    {
        public async Task<Pokemon> GetRandomPokemon()
        {
            Random rnd = new Random();
            var id = rnd.Next(0, 897) + 1;
            PokeApiClient pokeClient = new PokeApiClient();
            Pokemon p = await pokeClient.GetResourceAsync<Pokemon>(id);

            return p;
        }
    }
}
