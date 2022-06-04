using RoomexTechTestApi.Infrastructure.Calculator;
using RoomexTechTestApi.Infrastructure.MeasurementUnit;
using RoomexTechTestApi.Model;

namespace RoomexTechTestApi.Services
{
    /// <summary>
    /// Service for performing the calculation between two points.
    /// </summary>
    public class DistanceCalculatorService
    {
        private readonly BodyFactoryBase _factory;
        private readonly IUnitConverter _converter;

        /// <summary>
        /// Create a new instance of the <see cref="DistanceCalculatorService"/> class.
        /// </summary>
        /// <param name="factory">The body factory for retrieving calculators factories.</param>
        /// <param name="converter">The measurement unit converter.</param>
        /// <exception cref="ArgumentNullException"><paramref name="factory"/> is <see langword="null"/> -or- <paramref name="converter"/> is <see langword="null"/>.</exception>
        public DistanceCalculatorService(BodyFactoryBase factory, IUnitConverter converter)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            _converter = converter ?? throw new ArgumentNullException(nameof(converter));
        }

        /// <summary>
        /// Calculates the distance and performs any necessary transforms.
        /// </summary>
        /// <param name="body">The body on which the distance shall be calculated between two points.</param>
        /// <returns>The calculated distance.</returns>
        public double Process(Body body)
        {
            CalculatorFactoryBase factory = _factory.GetFactory(body.Form);
            ICalculator calculator = factory.GetCalculator(Cosmos.CalculationMethod.Pythagora);
            double metricResult = calculator.Process(body.Start, body.End);

            return _converter.Convert(metricResult, body.Unit);
        }
    }
}
