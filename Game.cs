using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_House_Game
{
    class Game : IGameState
    {
        private IGameState gameState;
        private InGame inGame;
        private ObjectManagement objectManagement;

        private Player player;
        private House house;
        private Object selectedObject;

        public Object SelectedObject
        {
            get { return selectedObject; }
            set { selectedObject = value; }
        }

        public Game()
        {
            house = new House();
            player = new Player(house.Corridor);
            gameState = new GameMenu();
            objectManagement = new ObjectManagement();
        }

        public void EnterButton()
        {

            gameState.EnterButton();
            if (gameState is GameMenu)
            {
                Console.Clear();
                inGame = new InGame(player);
                gameState = inGame;
            }

        }
        public void MButton()
        {
            if (gameState is InGame)
            {
                Console.Clear();
                inGame.MButton(player);
            }
        }
        public void IButton()
        {
            if (gameState is InGame)
            {
                Console.Clear();
                inGame.IButton(player);
            }
        }

        public void EscapeButton()
        {

            if (gameState is ObjectManagement || gameState is InGame)
            {
                Console.Clear();
                gameState = inGame;
                Console.WriteLine(player.PositionUpdate());
                player.ActualPosition.ShowObjects();
            }
            gameState.EscapeButton();
        }

        public void ArrowKeyUp()
        {
            if (gameState is InGame)
            {
                Console.Clear();
                inGame.ArrowKeyUp(player, house);
            }
        }
        public void ArrowKeyDown()
        {
            if (gameState is InGame)
            {
                Console.Clear();
                inGame.ArrowKeyDown(player, house);
            }
        }
        public void ArrowKeyLeft()
        {
            if (gameState is InGame)
            {
                Console.Clear();
                inGame.ArrowKeyLeft(player, house);
            }
        }

        public void ArrowKeyRight()
        {
            if (gameState is InGame)
            {
                Console.Clear();
                inGame.ArrowKeyRight(player, house);
            }
        }

        public void Numb(int numb)
        {
            if (gameState is InGame)
            {
                Console.Clear();
                selectedObject = objectManagement.ObjectProperties(player, numb);

                if (selectedObject != null)
                    gameState = objectManagement;
                else
                {
                    Console.WriteLine(player.PositionUpdate());
                    player.ActualPosition.ShowObjects();
                }
            }
            else if (gameState is ObjectManagement)
            {
                if (objectManagement.ObjectManage(house, player, numb, selectedObject) == true)
                {
                    Console.Clear();
                    gameState = inGame;
                    Console.WriteLine(player.PositionUpdate());
                    player.ActualPosition.ShowObjects();
                    selectedObject = null;
                }
            }
            player.CheckHp();
        }


        public void Exit()
        {
            gameState.Exit();
        }


    }
}
