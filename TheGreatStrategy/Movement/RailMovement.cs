using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatStrategy
{
    class RailMovement : IMovementBehaviour
    {
        public void StartMove()
        {
            Console.Write("The wheels on the rail slowly starts to roll forward.");
        }

        public void StopMove()
        {
            Console.Write("The wheels on the rail slowly comes to a stop.");
        }
    }
}
