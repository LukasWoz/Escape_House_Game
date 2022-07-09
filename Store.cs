using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_House_Game
{
    class Store : Object
    {
        private Object objectInside;
        List<Option> options = new List<Option>();

        public Store(string objectName, string description, bool destructable, int type, Object objectInside)
            : base(objectName, description, destructable, type)
        {
            this.objectInside = objectInside;
            options.Add(new Option(1, "Move it"));
        }
        public Object ObjectInside
        {
            get { return objectInside; }
            set { objectInside = value; }
        }

        public override string FindId(int id)
        {
            foreach (Option o in options)
            {
                if (o.ID == id)
                    return o.Name;
            }
            return null;
        }
        public override void DisplayOptions()
        {
            foreach (Option o in options)
            {
                Console.WriteLine("[" + o.ID + "] " + o.Name);
            }
        }
    }
}
