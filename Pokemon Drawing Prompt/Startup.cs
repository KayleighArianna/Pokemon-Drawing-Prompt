using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pokemon_Drawing_Prompt.Controllers;
using Pokemon_Drawing_Prompt.Data;
using Pokemon_Drawing_Prompt.Data.Interfaces;
using Pokemon_Drawing_Prompt.Generators;
using Pokemon_Drawing_Prompt.Generators.Interfaces;
using Pokemon_Drawing_Prompt.Menus.Interfaces;
using Pokemon_Drawing_Prompt.Services;
using Pokemon_Drawing_Prompt.Services.Interfaces;

namespace Pokemon_Drawing_Prompt
{
    public class Startup
    {
        IConfigurationRoot Configuration { get; }

        public Startup()
        {
            var builder = new ConfigurationBuilder();

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddTransient<IPromptGenerator, PromptGenerator>();
            services.AddTransient<IPokemonScenario, PokemonScenario>();
            services.AddTransient<IPokemonApiClient, PokemonApiClient>();
            services.AddTransient<IMainMenu, MainMenu>();
        }
    }
}