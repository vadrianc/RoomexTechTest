using RoomexTechTestApi.Model;

namespace RoomexTechTestApi.Infrastructure.Calculator
{
    /// <summary>
    /// Distance calculator interface.
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Calculates the distance between two points.
        /// </summary>
        /// <param name="start">The start point.</param>
        /// <param name="end">The end point.</param>
        /// <returns>The distance between the two points.</returns>
        double Process(Point start, Point end);
    }
}
