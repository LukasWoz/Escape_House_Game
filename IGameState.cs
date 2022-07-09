using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_House_Game
{
    interface IGameState
    {
        void EnterButton();
        void EscapeButton();
        void Exit();
    }
}
