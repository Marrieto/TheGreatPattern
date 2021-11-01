using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatStrategy
{
    class InternalCombustionEngineDiesel : IEngine
    {
        public void RefuelEngine()
        {
            Console.WriteLine("The fuel tanks is slowly filling up with Diesel");
        }

        public void StartEngine()
        {
            Console.WriteLine("The diesel engine starts LOUDLY!");
        }

        public void StopEngine()
        {
            Console.WriteLine("The diesel engine stops and it becomes silent.");
        }
    }
}
