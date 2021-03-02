using System;

namespace Strategy.ConcreteStrategy
{
    public class OvenBaking : ICookStrategy
    {
        public void Cook(string food)
        {
            Console.WriteLine($"\nCooking {food} by oven baking it.");
        }
    }
}