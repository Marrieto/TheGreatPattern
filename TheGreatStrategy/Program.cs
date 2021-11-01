using System;

namespace TheGreatStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var electricTrain = new ElectricTrain();
            var dieselTrain = new DieselTrain();

            electricTrain.Move();
            dieselTrain.Move();

            Console.ReadKey();
        }
    }
}
