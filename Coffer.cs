using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_House_Game
{
    class Coffer : Store
    {

        List<Option> options = new List<Option>();
        private bool locked;
        private string unlockCode;

        public Coffer(string objectName, string description, bool destructable, int type, Object objectInside, bool locked, string unlockCode)
            : base(objectName, description, destructable, type, objectInside)
        {
            this.locked = locked;
            this.unlockCode = unlockCode;

            if (type == 1)
            {
                options.Add(new Option(1, "Open it"));
                options.Add(new Option(2, "Destroy it"));
            }
            else if (type == 2)
            {
                options.Add(new Option(1, "Open it"));
            }
        }

        public bool Locked
        {
            get { return locked; }
            set { locked = value; }
        }
        public string UnlockCode
        {
            get { return unlockCode; }
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
                Console.WriteLine("[" + o.ID + "]" + o.Name);
            }
        }

    }
}
