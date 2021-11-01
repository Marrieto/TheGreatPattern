using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatStrategy
{
    class WheelMovement : IMovementBehaviour
    {
        public void StartMove()
        {
            Console.Write("The wheels starts to turn forward.");
        }

        public void StopMove()
        {
            Console.Write("The wheels comes to a stop.");
        }
    }
}
