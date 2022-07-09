using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_House_Game
{
    class Map
    {
        private string mapDescription;
        public Map()
        {
            mapDescription = "\n-------------------------\n|\t\t\t|\n|\tLiving Room\t|\n|\t\t\t|\n-----------   -----------\n|\t|\t|\t|\n|\t|\t|\t|\n|   ?   |\t Kitchen|\n|\t|\t|\t|\n|\t|\t|\t|\n-------------------------\n\t  Outside\n";
        }
        public string ShowMap()
        {
            return mapDescription;
        }
        public void MapUpdate()
        {
            mapDescription = "\n-------------------------\n|\t\t\t|\n|\tLiving Room\t|\n|\t\t\t|\n-----------   -----------\n|\t|\t|\t|\n|\t|\t|\t|\n| Final  \t Kitchen|\n| room  |\t|\t|\n|\t|\t|\t|\n-------------------------\n\t  Outside\n";
        }

    }
}
