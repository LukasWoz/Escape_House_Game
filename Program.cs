using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_House_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();

            while (true)
            {
                ConsoleKeyInfo opt = Console.ReadKey();

                switch (opt.Key)
                {
                    case ConsoleKey.Enter:
                        {
                            game.EnterButton();
                            break;
                        }

                    case ConsoleKey.Escape:
                        {
                            game.EscapeButton();
                            break;
                        }
                    case ConsoleKey.M:
                        {
                            game.MButton();
                            break;
                        }
                    case ConsoleKey.I:
                        {
                            game.IButton();
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            game.ArrowKeyUp();
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            game.ArrowKeyDown();
                            break;
                        }
                    case ConsoleKey.LeftArrow:
                        {
                            game.ArrowKeyLeft();
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            game.ArrowKeyRight();
                            break;
                        }
                    case ConsoleKey.F1:
                        {
                            game.Exit();
                            break;
                        }
                    case ConsoleKey.D1:
                        {
                            game.Numb(1);
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            game.Numb(2);
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            game.Numb(3);
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            game.Numb(4);
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }

            }

        }
    }
}
