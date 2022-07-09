using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_House_Game
{
    class Door
    {
        private bool locked = false;
        private string unlockCode = "NONE";

        public Door() { }
        public Door(bool locked, string unlockCode)
        {
            this.locked = locked;
            this.unlockCode = unlockCode;
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
    }
}
