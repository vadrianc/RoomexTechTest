namespace RoomexTechTestApi.Infrastructure.MeasurementUnit
{
    /// <summary>
    /// Measurement unit converter.
    /// </summary>
    public interface IUnitConverter
    {
        /// <summary>
        /// Convert the input from metric system to the specified new unit of measurement.
        /// </summary>
        /// <param name="input">The input value to convert.</param>
        /// <param name="newUnit">The new unit of measurement.</param>
        /// <returns>The converted value.</returns>
        double Convert(double input, string newUnit);
    }
}
