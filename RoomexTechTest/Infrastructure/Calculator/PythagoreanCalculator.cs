using RoomexTechTestApi.Model;

namespace RoomexTechTestApi.Infrastructure.Calculator
{
    /// <summary>
    /// Distance calculator that uses the approximation pythagorean method.
    /// </summary>
    public class PythagoreanCalculator : ICalculator
    {
        /// <summary>
        /// Calculate the distance between the two given points using the approximation pythagorean method.
        /// </summary>
        /// <param name="start">The start point.</param>
        /// <param name="end">The end point.</param>
        /// <returns>The distance between two points measured in km.</returns>
        public double Process(Point start, Point end)
        {
            return Math.Sqrt(
                Math.Pow(end.Latitude - start.Latitude, 2) +
                Math.Pow(end.Longitude - start.Longitude, 2));
        }
    }
}
