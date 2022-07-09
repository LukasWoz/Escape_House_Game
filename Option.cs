using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_House_Game
{
    class Option
    {
        private int iD;
        private string name;

        public Option(int iD, string name)
        {
            this.iD = iD;
            this.name = name;
        }
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string Name
        {
            get { return name; }
        }
    }
}
