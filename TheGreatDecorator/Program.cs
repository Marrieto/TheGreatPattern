using System;
using TheGreatDecorator.Base_Classes;
using TheGreatDecorator.Decorators;

namespace TheGreatDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza1 = new StandardPizza();
            pizza1 = new TomatoSauceDecorator(pizza1);
            pizza1 = new CheeseDecorator(pizza1);
            pizza1 = new BeefDecorator(pizza1);

            Console.WriteLine(pizza1.GetDescription());
            Console.WriteLine(pizza1.GetCost().ToString());
            Console.WriteLine("---------------------------\n");

            IPizza pizza2 = new PremiumPizza();
            pizza2 = new TomatoSauceDecorator(pizza2);
            pizza2 = new CheeseDecorator(pizza2);
            pizza2 = new CheeseDecorator(pizza2);
            pizza2 = new BeefDecorator(pizza2);
            pizza2 = new BeefDecorator(pizza2);

            Console.WriteLine(pizza2.GetDescription());
            Console.WriteLine(pizza2.GetCost().ToString());

            Console.ReadKey();
        }
    }
}
