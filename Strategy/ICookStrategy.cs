namespace Strategy
{
    /// <summary>
    /// The Strategy.
    /// Defines an interface common to all supported strategy algorithms.
    /// </summary>
    public interface ICookStrategy
    {
        void Cook(string food);
    }
}