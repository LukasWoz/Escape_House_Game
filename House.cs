using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_House_Game
{
    class House
    {
        private Room corridor;
        private Room livingRoom;
        private Room kitchen;
        private Room outside;
        private Room finalRoom;

        public House()
        {
            Object key0 = new Key("Coffer key", "A small key to the chest", false, 1, "0000");
            Object key1 = new Key("Final Room Key", "Door key", false, 1, "1234");
            Object key2 = new Key("Golden key", "It's might be outside key", false, 1, "666");
            Object key3 = new Key("Diamond key", "Outside door key", false, 1, "1111");

            corridor = new Room("Corridor", new Door());
            corridor.AddObject(new Object("Mirror", "It's old and dusty", true, 1));


            livingRoom = new Room("Living Room", new Door());
            livingRoom.AddObject(new Object("Painting", "Some old picture of parents with a child.", true, 1));
            livingRoom.AddObject(new Object("Mirror", "", true, 1));
            livingRoom.AddObject(new Coffer("Coffer", "Big locked coffer", true, 1, key1, true, "0000"));


            kitchen = new Room("Kitchen", new Door());
            kitchen.AddObject(new Object("Fridge", "Empty fridge. There seems to be nothing in it", true, 2));
            kitchen.AddObject(new Object("Table", "Heavy kitchen table", true, 2));
            kitchen.AddObject(key0);

            finalRoom = new Room("Final Room", new Door(true, "1234"));
            finalRoom.AddObject(new Store("Carpet", "Old and dusty carpet", true, 1, key3));


            finalRoom.AddObject(key2);
            outside = new Room("Outside", new Door(true, "1111"));
        }

        public Room Corridor
        {
            get { return corridor; }
            set { corridor = value; }
        }
        public Room LivingRoom
        {
            get { return livingRoom; }
            set { livingRoom = value; }
        }
        public Room Kitchen
        {
            get { return kitchen; }
            set { kitchen = value; }
        }
        public Room FinalRoom
        {
            get { return finalRoom; }
            set { FinalRoom = value; }
        }
        public Room Outside
        {
            get { return outside; }
            set { outside = value; }
        }

        public void HouseManage(Room room)
        {
            if (room.Name == corridor.Name && (room != corridor))
            {
                corridor = room;
            }
            else if (room.Name == livingRoom.Name && (room != corridor))
            {
                livingRoom = room;
            }
            else if (room.Name == kitchen.Name && (room != corridor))
            {
                kitchen = room;
            }
            else if (room.Name == finalRoom.Name && (room != corridor))
            {
                finalRoom = room;
            }
        }
    }
}
