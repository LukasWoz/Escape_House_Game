using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_House_Game
{
    class Key : Object
    {
        private string unlockCode;

        List<Option> options = new List<Option>();

        public Key(string objectName, string description, bool destructable, int type, string unlockCode) : base(objectName, description, destructable, type)
        {
            this.unlockCode = unlockCode;
            options.Add(new Option(1, "Take it"));
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
                Console.WriteLine("[" + o.ID + "] " + o.Name);
            }
        }
    }
}
