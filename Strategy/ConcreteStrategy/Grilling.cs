using System;

namespace Strategy.ConcreteStrategy
{
    public class Grilling : ICookStrategy
    {
        public void Cook(string food)
        {
            Console.WriteLine($"\nCooking {food} by grilling it.");
        }
    }
}