using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class ControlKeys
    {
        static int controlKeysCount = 4;

        ConsoleKey MovementUp;
        ConsoleKey MovementDown;
        ConsoleKey MovementRight;
        ConsoleKey MovementLeft;

        public static int KeyCount { get { return controlKeysCount; } }

    }
}
