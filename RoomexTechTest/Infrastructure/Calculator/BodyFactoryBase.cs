namespace RoomexTechTestApi.Infrastructure.Calculator
{
    /// <summary>
    /// Abstract factory base class for calculator factories.
    /// </summary>
    public abstract class BodyFactoryBase
    {
        /// <summary>
        /// Get the calculator factory instance based on the shape of the body.
        /// </summary>
        /// <param name="body">The body shape.</param>
        /// <returns>An <see cref="CalculatorFactoryBase"/> instance.</returns>
        public abstract CalculatorFactoryBase GetFactory(string body);
    }
}
