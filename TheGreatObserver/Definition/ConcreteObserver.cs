using System;

namespace TheGreatObserver.Definition
{
    public class ConcreteObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("I'm a ConcreteObserver and I just got updated!");
        }
    }
}