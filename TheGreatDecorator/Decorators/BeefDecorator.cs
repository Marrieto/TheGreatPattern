using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatDecorator.Decorators
{
    public class BeefDecorator : PizzaDecorator
    {
        public BeefDecorator(IPizza pizza) : base(pizza)
        { 
        }

        public override double GetCost()
        {
            return this.tempPizza.GetCost() + 0.5;
        }

        public override string GetDescription()
        {
            return this.tempPizza.GetDescription() + "\n+ Beef meat";
        }
    }
}
