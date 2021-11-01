using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatDecorator.Base_Classes
{
    class StandardPizza : IPizza
    {
        public double GetCost()
        {
            return 2.00;
        }

        public string GetDescription()
        {
            return "Standard Pizza";
        }
    }
}
