using RoomexTechTestApi.Infrastructure.CustomException;

namespace RoomexTechTestApi.Infrastructure.Calculator
{
    /// <summary>
    /// Factory for retrieving the calculator factories.
    /// </summary>
    public class BodyFactory : BodyFactoryBase
    {
        /// <summary>
        /// Get the calculator factory based on the body shape.
        /// </summary>
        /// <param name="body">The body shape.</param>
        /// <returns>An <see cref="CalculatorFactoryBase"/> instance.</returns>
        /// <exception cref="UnknownShapeException"><paramref name="body"/> is not supported.</exception>
        public override CalculatorFactoryBase GetFactory(string body)
        {
            if (string.Equals(body, Cosmos.BodyShape.Sphere))
            {
                return new SpheroidCalculatorFactory(Cosmos.Radius.Earth);
            }

            throw new UnknownShapeException(body);
        }
    }
}
