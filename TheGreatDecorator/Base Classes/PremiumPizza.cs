using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatDecorator.Base_Classes
{
    class PremiumPizza : IPizza
    {
        public double GetCost()
        {
            return 3.50;
        }

        public string GetDescription()
        {
            return "Premium Pizza";
        }
    }
}
