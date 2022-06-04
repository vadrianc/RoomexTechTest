using RoomexTechTestApi;
using RoomexTechTestApi.Infrastructure.CustomException;
using RoomexTechTestApi.Model;
using RoomexTechTestApi.Services;

namespace RoomexTechTestApiTest
{
    public class Tests
    {
        [TestCase(Cosmos.BodyShape.Sphere, 53.297975, -6.372663, 41.385101, -81.440440, Cosmos.DistanceUnits.Kilometre, 76.007155654330361d)]
        [TestCase(Cosmos.BodyShape.Sphere, 53.297975, -6.372663, 41.385101, -81.440440, Cosmos.DistanceUnits.Mile, 47.228642316086912d)]
        public void ProcessValidInput(string form, double latitude1, double longitude1, double latitude2, double longitude2, string unit, double expectedResult)
        {
            Point start = new(latitude1, longitude1);
            Point end = new(latitude2, longitude2);
            Body body = new(start, end, form, unit);

            DistanceCalculatorService service = new();
            double result = service.Process(body);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void UnrecognizedBody()
        {
            Point start = new(1, 2);
            Point end = new(4, 5);
            Body body = new(start, end, "unknown", Cosmos.DistanceUnits.Mile);

            DistanceCalculatorService service = new();
            Assert.That(() => { service.Process(body); }, Throws.TypeOf<BodyShapeException>());
        }
    }
}