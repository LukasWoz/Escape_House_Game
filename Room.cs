using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_House_Game
{
    class Room
    {
        private string name;
        //private bool isLocked;
        private Door door;
        List<Object> objectList = new List<Object>();

        public Room(string name, Door door)
        {
            this.name = name;
            this.door = door;
        }
        public string Name
        {
            get { return name; }
        }

        public Door Door
        {
            get { return door; }
            set { door = value; }
        }
        public List<Object> ObjectList
        {
            get { return objectList; }
            set { objectList = value; }
        }

        public void AddObject(Object _object)
        {
            objectList.Add(_object);
            UpdateObjectId();
        }



        public void RemoveObject(Object _object)
        {
            if (_object.Type == 1)
            {
                for (int i = ObjectList.Count - 1; i >= 0; i--)
                {
                    if (ObjectList[i].ObjectName == _object.ObjectName)
                    {
                        objectList.Remove(ObjectList[i]);
                    }
                }
                UpdateObjectId();
            }
        }

        public void ObjectDestroy(Object _object)
        {
            if (_object.Destructable == true)
            {
                bool thereis = false;
                foreach (Object o in ObjectList)
                {
                    if (o == _object)
                    {
                        o.ObjectName = "Destroyed " + o.ObjectName;
                        //o.Destructable = false;
                        if (o is Coffer)
                            thereis = true;
                    }

                }
                if (thereis == true)
                {
                    Store store = (Store)_object;
                    if (store.ObjectInside != null)
                    {
                        Key key = (Key)store.ObjectInside;
                        store.ObjectInside = null;
                        _object = store;
                        objectList.Add(key);
                        UpdateObjectId();
                    }

                }
            }
        }

        public void MoveObject(Object _object)
        {
            bool thereis = false;
            foreach (Object o in ObjectList)
            {
                if (o == _object)
                {
                    if (o is Store)
                        thereis = true;
                }
            }
            if (thereis == true)
            {
                Store store = (Store)_object;
                Key key = (Key)store.ObjectInside;
                store.ObjectInside = null;
                _object = store;

                objectList.Add(key);
                UpdateObjectId();
            }
        }
        public void OpenObject(Coffer _coffer)
        {
            if (_coffer.ObjectInside != null)
            {
                Key key = (Key)_coffer.ObjectInside;
                _coffer.ObjectInside = null;
                objectList.Add(key);
                UpdateObjectId();
            }
        }



        public void ShowObjects()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Objects in room: ");
            foreach (Object o in objectList)
            {
                Console.WriteLine("[" + o.ID + "] " + o.ObjectName);
            }
        }
        public void UpdateObjectId()
        {
            int id = 1;
            foreach (Object o in objectList)
            {
                o.ID = id;
                id++;
            }
        }

        public Object FindObject(int id)
        {
            foreach (Object o in objectList)
            {
                if (o.ID == id)
                {
                    return o;
                }
            }
            return null;
        }

    }
}
