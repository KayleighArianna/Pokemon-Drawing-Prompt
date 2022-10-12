using System.Threading.Tasks;

namespace Pokemon_Drawing_Prompt.Menus.Interfaces
{
    public interface IMainMenu
    {
        Task Menu();
        Task Reset();
    }
}