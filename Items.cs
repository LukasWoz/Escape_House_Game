using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_House_Game
{
    class Items
    {
        List<Object> itemList = new List<Object>();
        /*
        public List<Object> ItemList
        {
            get { return itemList; }
            set { itemList = value; }
        }
        */
        public void ShowItems()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Your items: ");
            foreach (Object o in itemList)
            {
                Console.WriteLine("[" + o.ID + "] " + o.ObjectName);
            }
        }

        public void AddItem(Object _object)
        {

            _object.ID = UpdateItemId();
            itemList.Add(_object);

        }
        public int UpdateItemId()
        {
            int id = 1;
            foreach (Object o in itemList)
            {
                id++;
            }
            return id;
        }

        public bool FindKey(string code)
        {
            Key key;
            foreach (Object i in itemList)
            {
                if (i is Key)
                {
                    key = (Key)i;
                    if (key.UnlockCode == code)
                        return true;
                }
            }
            return false;
        }
    }
}
