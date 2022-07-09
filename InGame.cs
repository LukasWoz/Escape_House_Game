using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_House_Game
{
    class InGame : IGameState
    {

        public InGame(Player player)
        {
            Console.WriteLine(player.PositionUpdate());
            player.ActualPosition.ShowObjects();
        }
        public void EnterButton()
        {
            Console.Clear();
            Console.WriteLine("\n\n|---------------------------------------------");
            Console.WriteLine("|\n|\tGame Manual:  \n|");
            Console.WriteLine("|\tTo win:  Get out of the house\n|");
            Console.WriteLine("|\tMoving around the house: Arrow Buttons");
            Console.WriteLine("|\tI - View items you own\n|\tM - Show map");

        }

        public void MButton(Player player)
        {
            Console.WriteLine(player.Map.ShowMap());
            Console.WriteLine(player.PositionUpdate());
        }

        public void IButton(Player player)
        {
            player.Equipment.ShowItems();
        }

        public void EscapeButton() { }

        public void ArrowKeyUp(Player player, House house)
        {
            if (player.ActualPosition == house.Corridor)
            {
                player.Move(house.LivingRoom);
            }
            Console.WriteLine(player.PositionUpdate());
            player.ActualPosition.ShowObjects();
        }
        public void ArrowKeyDown(Player player, House house)
        {
            if (player.ActualPosition == house.Corridor)
            {
                if (player.Move(house.Outside))
                    if (player.HaveWon == false)
                        Console.WriteLine("\n\tCongratulations!!!! You have won.\n");

            }
            else if (player.ActualPosition == house.LivingRoom)
            {
                player.Move(house.Corridor);
            }
            Console.WriteLine(player.PositionUpdate());
            player.ActualPosition.ShowObjects();
        }

        public void ArrowKeyLeft(Player player, House house)
        {
            if (player.ActualPosition == house.Corridor)
            {
                player.Move(house.FinalRoom);
            }
            else if (player.ActualPosition == house.Kitchen)
            {
                player.Move(house.Corridor);
            }
            Console.WriteLine(player.PositionUpdate());
            player.ActualPosition.ShowObjects();
        }

        public void ArrowKeyRight(Player player, House house)
        {
            if (player.ActualPosition == house.Corridor)
            {
                player.Move(house.Kitchen);
            }
            else if (player.ActualPosition == house.FinalRoom)
            {
                player.Move(house.Corridor);
            }
            Console.WriteLine(player.PositionUpdate());
            player.ActualPosition.ShowObjects();
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
