using Pokemon_Drawing_Prompt.Data;
using Pokemon_Drawing_Prompt.Generators.Interfaces;
using Pokemon_Drawing_Prompt.Menus.Interfaces;
using System;
using System.Threading.Tasks;

namespace Pokemon_Drawing_Prompt.Controllers
{
    public class MainMenu : IMainMenu
    {
        private readonly IPromptGenerator _promptGenerator;
        public MainMenu(IPromptGenerator promptGenerator)
        {
            _promptGenerator = promptGenerator;
        }
        public async Task Menu()
        {
            Console.WriteLine("Your options are:");
            Console.WriteLine("# 1 - \'prompt me\'");
            Console.WriteLine("# 2 - \'prompt me many\'");
            Console.WriteLine("... And that is all.");

            var choice = Console.ReadLine().ToString().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "prompt me":
                case "1":
                    Console.WriteLine(AsciiTitleConstants.YourDrawingPrompt);
                    Console.WriteLine("~~~~~~~~~~~~~~~~~");
                    Console.WriteLine(await _promptGenerator.GetPrompt());
                    Console.WriteLine("~~~~~~~~~~~~~~~~~");
                    break;
                case "prompt me many":
                case "2":
                    await ManyPromptsMenu();
                    break;
                default:
                    Console.WriteLine("Something went wrong.");
                    Reset();
                    break;
            }

            Console.ReadKey();
            await Reset();
        }

        public async Task ManyPromptsMenu()
        {
            Console.WriteLine("How many prompts would you like?");
            var input = Console.ReadLine();
            int amount;
            if (int.TryParse(input, out amount))
            {
                Console.Clear();
                Console.WriteLine(AsciiTitleConstants.YourDrawingPrompts);
                await _promptGenerator.GetManyPrompts(amount);
            }
            else
            {
                Console.WriteLine("Something went wrong.");
                Reset();
            }
        }

        public async Task Reset()
        {
            Console.WriteLine();
            Console.WriteLine("Continue?");
            Console.WriteLine("# 1 - \'yes\'");
            Console.WriteLine("# 2 - \'no\'");
            var choice = Console.ReadLine().ToString().ToLower();
            if (choice == "yes" || choice == "1" || choice == "y")
            {
                await Menu();
            }
            else
            {
                Console.ReadLine();
            }
        }

    }
}
