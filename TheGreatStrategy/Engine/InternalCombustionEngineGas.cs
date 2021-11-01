using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatStrategy
{
    class InternalCombustionEngineGas : IEngine
    {
        public void RefuelEngine()
        {
            Console.WriteLine("The fuel tanks is slowly filling up with Gas");
        }

        public void StartEngine()
        {
            Console.WriteLine("The gas engine starts!");
        }

        public void StopEngine()
        {
            Console.WriteLine("The gas engine stops and it becomes silent.");
        }
    }
}
