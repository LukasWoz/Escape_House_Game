using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_House_Game
{
    class GameMenu : IGameState
    {

        public GameMenu()
        {
            Console.WriteLine("\nGAME MENU\n");
            Console.WriteLine("[Enter] PRESS TO START YOUR JOURNEY\n\n");
            Console.WriteLine("[Esc] PRESS TO EXIT\n\n");
        }

        public void EnterButton() { }

        public void EscapeButton()
        {
            //exit program
            Console.WriteLine("Exiting");
            Environment.Exit(0);
        }
        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
