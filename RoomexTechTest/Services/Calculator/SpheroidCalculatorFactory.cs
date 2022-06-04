namespace RoomexTechTestApi.Services.Calculator
{
    /// <summary>
    /// Factory for spherical body related calculators.
    /// </summary>
    public class SpheroidCalculatorFactory : CalculatorFactoryBase
    {
        private readonly double _radius;

        /// <summary>
        /// Create a new instance of the <see cref="SpheroidCalculatorFactory"/> class.
        /// </summary>
        /// <param name="radius">The radius of the spherical body.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="radius"/> is negative or zero.</exception>
        public SpheroidCalculatorFactory(double radius)
        {
            if (radius <= 0) throw new ArgumentOutOfRangeException(nameof(radius));

            _radius = radius;
        }

        /// <summary>
        /// Get a calculator for the distance between two points found on a spherical body.
        /// </summary>
        /// <param name="type">The type of the calculator.</param>
        /// <returns>The specified calculator type instance.</returns>
        public override ICalculator GetCalculator(string type)
        {
            if (string.Equals(type, Cosmos.CalculationMethod.Pythagora, StringComparison.InvariantCultureIgnoreCase))
            {
                return new PythagoreanCalculator();    
            }

            return new DefaultCalculator();
        }
    }
}
