namespace RoomexTechTestApi.Services.MeasurementUnit
{
    /// <summary>
    /// Functionality for converting metric values.
    /// </summary>
    public class MetricConverter : IUnitConverter
    {
        /// <summary>
        /// Convert the given metric input to a new unit of measurement.
        /// </summary>
        /// <param name="input">The input measured in km.</param>
        /// <param name="newUnit">The new unit of measurement.</param>
        /// <returns>The input equivalent measured in the specified <paramref name="newUnit"/>.</returns>
        /// <exception cref="ArgumentException">The <paramref name="newUnit"/> is not supported.</exception>
        /// <remarks>
        /// If the <paramref name="newUnit"/> is km, the same <paramref name="input"/> shall be returned.
        /// </remarks>
        public double Convert(double input, string newUnit)
        {
            if (string.Equals(newUnit, Cosmos.DistanceUnits.Mile, StringComparison.OrdinalIgnoreCase))
            {
                return input * 0.621371d;
            }
            else if (string.Equals(newUnit, Cosmos.DistanceUnits.Kilometre, StringComparison.OrdinalIgnoreCase))
            {
                return input;
            }

            throw new ArgumentException(nameof(newUnit));
        }
    }
}
