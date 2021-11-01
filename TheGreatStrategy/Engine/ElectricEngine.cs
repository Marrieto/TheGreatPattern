using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatStrategy
{
    class ElectricEngine : IEngine
    {
        public void RefuelEngine()
        {
            Console.Write("Plugging the cord into the vehicle. The vehicle batteries is now charging..");
        }

        public void StartEngine()
        {
            Console.Write("The power light is now on.");
        }

        public void StopEngine()
        {
            Console.Write("The power light turns off.");
        }
    }
}
