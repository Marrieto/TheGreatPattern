using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatDecorator.Decorators
{
    public class TomatoSauceDecorator : PizzaDecorator
    {
        public TomatoSauceDecorator(IPizza pizza) : base(pizza)
        { 
        }

        public override double GetCost()
        {
            return this.tempPizza.GetCost() + 0.1;
        }

        public override string GetDescription()
        {
            return this.tempPizza.GetDescription() + "\n+ Tomato sauce";
        }
    }
}
