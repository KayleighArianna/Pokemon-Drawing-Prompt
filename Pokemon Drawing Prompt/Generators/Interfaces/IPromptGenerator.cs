using System.Threading.Tasks;

namespace Pokemon_Drawing_Prompt.Generators.Interfaces
{
    public interface IPromptGenerator
    {
        Task<string> GetPrompt();
        Task GetManyPrompts(int amount);
    }
}