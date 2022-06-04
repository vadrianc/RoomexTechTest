namespace RoomexTechTestApi.Model
{
    /// <summary>
    /// Holds details of a body.
    /// </summary>
    public class Body
    {
        /// <summary>
        /// Create a new instance of the <see cref="Body"/> class.
        /// </summary>
        /// <param name="start">The start point.</param>
        /// <param name="end">The end point.</param>
        /// <param name="form">The shape of the body.</param>
        /// <param name="unit">The unit of measurement for the distance between the start end end points.</param>
        public Body(Point start, Point end, string form, string unit)
        {
            Start = start;
            End = end;
            Form = form;
            Unit = unit;
        }


        /// <summary>
        /// Get the start point.
        /// </summary>
        public Point Start { get; private set; }

        /// <summary>
        /// Get the end point.
        /// </summary>
        public Point End { get; private set; }

        /// <summary>
        /// Get the shape of the body.
        /// </summary>
        public string Form { get; private set; }

        /// <summary>
        /// Get the unit of measurement for the distance between the start end end points.
        /// </summary>
        public string Unit { get; private set; }
    }
}
