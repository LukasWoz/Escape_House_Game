using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_House_Game
{
    class Player
    {
        private string name;
        private int hp;
        private bool haveWon = false;
        private Room actualPosition;
        private Map map;
        private Items equipment;


        public Player(Room room)
        {
            name = "Player";
            hp = 100;
            actualPosition = room;
            map = new Map();
            equipment = new Items();
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }
        public bool HaveWon
        {
            get { return haveWon; }
            set { haveWon = value; }
        }
        public Map Map
        {
            get { return map; }
        }
        public Items Equipment
        {
            get { return equipment; }
            set { equipment = value; }
        }
        public Room ActualPosition
        {
            get { return actualPosition; }
            set { actualPosition = value; }
        }
        public string PositionUpdate()
        {
            return "You are actually in " + ActualPosition.Name;
        }

        public void CheckHp()
        {
            if (hp == 0)
            {
                Console.Clear();
                Console.WriteLine("\nYou died. Game Over");
                Environment.Exit(0);
            }

        }
        public bool Move(Room nextPosition)
        {
            if (nextPosition.Door.Locked == false)
            {
                this.actualPosition = nextPosition;
                return true;
            }
            else if (OpenDoor(nextPosition.Door) == true)
            {
                this.actualPosition = nextPosition;
                return true;
            }

            Console.WriteLine("You don't have the key for this door.\n");
            return false;
        }

        public bool OpenDoor(Door door)
        {
            bool state = equipment.FindKey(door.UnlockCode);
            if (state == true)
                Map.MapUpdate();
            return state;
        }

    }
}
