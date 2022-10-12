using Microsoft.Extensions.DependencyInjection;
using Pokemon_Drawing_Prompt.Controllers;
using Pokemon_Drawing_Prompt.Data;
using Pokemon_Drawing_Prompt.Generators;
using Pokemon_Drawing_Prompt.Menus.Interfaces;
using Pokemon_Drawing_Prompt.Services;
using System;
using System.Threading.Tasks;

namespace Pokemon_Drawing_Prompt
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            // Startup.cs finally :)
            Startup startup = new Startup();
            startup.ConfigureServices(services);
            await StartGame();
            
        }

        public static async Task StartGame()
        {
            Console.WriteLine(AsciiTitleConstants.PokemonDrawingPrompt);
            var image = new PokemonImages();
            Console.WriteLine(image.GetPokemonImage());

            //TODO: Find a better way to connect to menu as dependency injection is difficult with a static method
            var pokemonApiClient = new PokemonApiClient();
            var promptGenerator = new PromptGenerator(pokemonApiClient);
            var menu = new MainMenu(promptGenerator);
            await menu.Menu();

            Console.WriteLine("Thank you for playing - Kay Pope 2022");
            Console.ReadKey();
        }

    }
}
