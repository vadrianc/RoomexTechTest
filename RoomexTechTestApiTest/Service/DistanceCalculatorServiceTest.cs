using RoomexTechTestApi;
using RoomexTechTestApi.Infrastructure.Calculator;
using RoomexTechTestApi.Infrastructure.CustomException;
using RoomexTechTestApi.Infrastructure.MeasurementUnit;
using RoomexTechTestApi.Model;
using RoomexTechTestApi.Services;
using RoomexTechTestApiTest.Infrastructure.Calculator.Mock;

namespace RoomexTechTestApiTest.Service
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

            DistanceCalculatorService service = new(new BodyFactory(), new MetricConverter());
            double result = service.Process(body);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void ExecutionPathProof()
        {
            Point start = new(1, 2);
            Point end = new(4, 5);
            Body body = new(start, end, "unknown", Cosmos.DistanceUnits.Kilometre);

            DistanceCalculatorService service = new(new BodyFactoryMock(), new MetricConverter());
            double result = service.Process(body);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void ConversionProof()
        {
            Point start = new(53.297975, -6.372663);
            Point end = new(41.385101, -81.440440);
            Body body = new(start, end, Cosmos.BodyShape.Sphere, Cosmos.DistanceUnits.Kilometre);

            DistanceCalculatorService service = new(new BodyFactory(), new ConverterMock());
            double result = service.Process(body);
            Assert.That(result, Is.EqualTo(76.007155654330361d * 3));
        }

        [Test]
        public void UnrecognizedBody()
        {
            Point start = new(1, 2);
            Point end = new(4, 5);
            Body body = new(start, end, "unknown", Cosmos.DistanceUnits.Mile);

            DistanceCalculatorService service = new(new BodyFactory(), new MetricConverter());
            Assert.That(() => { service.Process(body); }, Throws.TypeOf<UnknownShapeException>());
        }
    }
}