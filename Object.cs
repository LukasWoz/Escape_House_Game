using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_House_Game
{
    class Object
    {
        private int iD;
        private string objectName;
        private string description;
        private bool destructable;
        private int type;
        List<Option> options = new List<Option>();

        public Object(string objectName, string description, bool destructable, int type)
        {
            this.objectName = objectName;
            this.description = description;
            this.destructable = destructable;
            this.type = type;
            if (type == 1)
            {
                options.Add(new Option(1, "Move it"));
                options.Add(new Option(2, "Destroy it"));
            }
            else if (type == 2)
            {
                options.Add(new Option(1, "Move it"));
            }
            else if (type == 3)
            {
                options.Add(new Option(1, "Destroy it"));
                options.Add(new Option(2, "Take it"));
            }
        }
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string ObjectName
        {
            get { return objectName; }
            set { objectName = value; }
        }
        public bool Destructable
        {
            get { return destructable; }
            set { destructable = value; }
        }
        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        public List<Option> Options
        {
            get { return options; }
            set { options = value; }
        }

        public virtual string FindId(int id)
        {
            foreach (Option o in options)
            {
                if (o.ID == id)
                    return o.Name;
            }
            return null;
        }
        public virtual void DisplayOptions()
        {
            foreach (Option o in options)
            {
                Console.WriteLine("[" + o.ID + "] " + o.Name);
            }
        }

        public string ObjectProperties()
        {
            return "\n" + objectName + "\t-" + description + "\n";
        }
    }
}
