namespace RoomexTechTestApi.Services.Calculator
{
    /// <summary>
    /// Base factory for instantiating a distance calculator.
    /// </summary>
    public abstract class CalculatorFactoryBase
    {
        /// <summary>
        /// Get instance of a distance calculator of the specified type.
        /// </summary>
        /// <param name="type">The type of the distance calculator.</param>
        /// <returns>An <see cref="ICalculator"/> instance.</returns>
        public abstract ICalculator GetCalculator(string type);
    }
}
