using System;

namespace Strategy.ConcreteStrategy
{
    public class DeepFrying : ICookStrategy
    {
        public void Cook(string food)
        {
            Console.WriteLine($"\nCooking {food} by deep frying it");
        }
    }
}