using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_House_Game
{
    class ObjectManagement : IGameState
    {
        public ObjectManagement() { }
        public void EnterButton() { }
        public void EscapeButton() { }

        public bool ObjectManage(House house, Player player, int numb, Object _object)
        {
            string opt = _object.FindId(numb);
            if (opt != null)
            {
                if (opt == "Take it")
                {
                    player.Equipment.AddItem(_object);
                    player.ActualPosition.RemoveObject(_object);
                    house.HouseManage(player.ActualPosition);
                    return true;
                }
                else if (opt == "Destroy it")
                {
                    if (_object.ObjectName.StartsWith("Destroyed"))
                    {
                        player.Hp -= 25;
                    }
                    else
                    {
                        player.ActualPosition.ObjectDestroy(_object);
                        house.HouseManage(player.ActualPosition);

                    }
                    return true;
                }
                else if (opt == "Move it")
                {
                    player.ActualPosition.MoveObject(_object);
                    house.HouseManage(player.ActualPosition);
                    return true;
                }
                else if (opt == "Open it")
                {
                    Coffer coffer = (Coffer)_object;
                    if (player.Equipment.FindKey(coffer.UnlockCode) == true)
                    {
                        player.ActualPosition.OpenObject(coffer);
                        house.HouseManage(player.ActualPosition);
                    }
                    return true;
                }
            }
            Console.WriteLine("There is no such an option");
            return false;
        }
        public Object ObjectProperties(Player player, int numb)
        {
            Object _object = player.ActualPosition.FindObject(numb);
            if (_object != null)
            {
                Console.WriteLine(_object.ObjectProperties());
                Console.WriteLine("Choose what you want to do with it:");
                _object.DisplayOptions();
            }
            return _object;
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
