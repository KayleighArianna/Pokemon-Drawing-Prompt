using PokeApiNet;
using Pokemon_Drawing_Prompt.Data;
using Pokemon_Drawing_Prompt.Generators.Interfaces;
using Pokemon_Drawing_Prompt.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace Pokemon_Drawing_Prompt.Generators
{
    public class PromptGenerator : IPromptGenerator
    {
        private readonly IPokemonApiClient _pokemonApiClient;
        public PromptGenerator(IPokemonApiClient pokemonApiClient)
        {
            _pokemonApiClient = pokemonApiClient;
        }
        public async Task<string> GetPrompt()
        {
            try
            {
                Pokemon firstPokemon = await _pokemonApiClient.GetRandomPokemon();
                Pokemon secondPokemon = await _pokemonApiClient.GetRandomPokemon();
                PokemonScenario scenario = new PokemonScenario();

                return scenario.GetPokemonScenario(firstPokemon.Name, secondPokemon.Name);
            }
            catch
            {
                return "Looks like Team Rocket have thwarted your fun.";
            }
        }

        public async Task GetManyPrompts(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(await GetPrompt());
                Console.WriteLine("~~~~~~~~~~~~~~~~~");
            }
        }

    }
}
