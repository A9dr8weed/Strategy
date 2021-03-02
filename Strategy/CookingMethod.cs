using System;

namespace Strategy
{
    /// <summary>
    /// The Context class, which maintains a reference to the chosen Strategy.
    /// </summary>
    public class CookingMethod
    {
        /// <summary>
        /// Food name.
        /// </summary>
        private string Food;

        /// <summary>
        /// Reference to the chosen Strategyю
        /// </summary>
        private ICookStrategy _cookStrategy;

        /// <summary>
        /// The Context allows replacing a Strategy object at runtime.
        /// </summary>
        /// <param name="cookStrategy"> Choosen strategy. </param>
        public void SetCookStrategy(ICookStrategy cookStrategy)
        {
            _cookStrategy = cookStrategy;
        }

        public void SetFood(string name)
        {
            Food = name;
        }

        /// <summary>
        /// The Context delegates some work to the Strategy object instead of
        /// implementing multiple versions of the algorithm on its own.
        /// </summary>
        public void Cook()
        {
            _cookStrategy.Cook(Food);
            Console.WriteLine();
        }
    }
}