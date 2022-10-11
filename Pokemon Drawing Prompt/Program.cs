using System;
using System.Threading.Tasks;
using PokeApiNet;

namespace Pokemon_Drawing_Prompt
{
    public class Program
    {

        public static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to the fantabulous Pokemon Drawing Prompt Machine");
            await Menu();
            
            Console.ReadLine();
        }

        private static async Task Reset()
        {
            Console.WriteLine();
            Console.WriteLine("Continue?");
            Console.WriteLine("# 1 - /'yes'/");
            Console.WriteLine("# 2 - /'no'/");
            if (Console.ReadLine().ToLower() == "yes" || Console.ReadLine() == "1" || Console.ReadLine().ToLower() == "y")
            {
                await Menu();
            }
            else
            {
                Console.ReadLine();
            }
        }

        private static async Task Menu()
        {
            Console.WriteLine("Your options are:");
            Console.WriteLine("# 1 - /'prompt me/'");
            Console.WriteLine("... And that is all.");
            if (Console.ReadLine().ToLower() == "prompt me" || Console.ReadLine() == "1")
            {
                await GetPrompt();
            }

            Console.ReadKey();
            await Reset();
        }

        private static async Task GetPrompt()
        {
            Console.Clear();
            try
            {
                Pokemon firstPokemon = await GetRandomPokemon();
                Pokemon secondPokemon = await GetRandomPokemon();
                PokemonScenario scenario = new PokemonScenario();

                Console.WriteLine("Your Drawing Prompt:");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine(scenario.GetPokemonScenario(firstPokemon.Name, secondPokemon.Name));
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            }
            catch
            {
                Console.WriteLine("Looks like Team Rocket have thwarted your fun.");
            }
        }

        private static async Task<Pokemon> GetRandomPokemon()
        {
            Random rnd = new Random();
            var id = rnd.Next(0, 897) + 1;
            PokeApiClient pokeClient = new PokeApiClient();
            Pokemon p = await pokeClient.GetResourceAsync<Pokemon>(id);
            return p;
        }

    }
}
