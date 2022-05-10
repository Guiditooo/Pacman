using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class InputManager
    {
        List<Player> movementKeysList;

        public InputManager(List<Player> movementKeysList)
        {
            this.movementKeysList = movementKeysList;
        }
        
        public void CheckInputs()
        {
            
            for (int i = 0; i < movementKeysList.Count(); i++)
            {
                for (int  j = 0;  j < ControlKeys.KeyCount;  j++)
                {
                    
                }
            }
        }

    }
}
