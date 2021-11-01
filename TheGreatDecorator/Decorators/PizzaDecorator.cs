using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatDecorator.Decorators
{
    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza tempPizza;

        public PizzaDecorator(IPizza pizza)
        {
            tempPizza = pizza;
        }

        public abstract double GetCost();

        public abstract string GetDescription();

    }
}
