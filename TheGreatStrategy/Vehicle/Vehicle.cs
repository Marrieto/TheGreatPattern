using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatStrategy
{
    public abstract class Vehicle
    {
        public IEngine Engine { get; set; }
        
        public IMovementBehaviour MovementBehaviour { get; set; }

        public void Move()
        {
            Engine.RefuelEngine();
            Console.WriteLine("\n");
            Engine.StartEngine();
            Console.WriteLine("\n");
            MovementBehaviour.StartMove();
            Console.WriteLine("\n");
            MovementBehaviour.StopMove();
            Console.WriteLine("\n");
            Engine.StopEngine();
            Console.WriteLine("\n");
        }
    }
}
