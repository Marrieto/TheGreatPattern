using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatDecorator.Decorators
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        { 
        }

        public override double GetCost()
        {
            return this.tempPizza.GetCost() + 0.3;
        }

        public override string GetDescription()
        {
            return this.tempPizza.GetDescription() + "\n+ Cheese";
        }
    }
}
