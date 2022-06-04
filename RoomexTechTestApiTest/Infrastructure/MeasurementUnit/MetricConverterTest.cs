using RoomexTechTestApi;
using RoomexTechTestApi.Infrastructure.MeasurementUnit;

namespace RoomexTechTestApiTest.Infrastructure.MeasurementUnit
{
    internal class MetricConverterTest
    {
        [TestCase(76.007155654330361d, Cosmos.DistanceUnits.Kilometre, 76.007155654330361d)]
        [TestCase(76.007155654330361d, Cosmos.DistanceUnits.Mile, 47.228642316086912d)]
        public void ConvertTo(double value, string newUnit, double expectedValue)
        {
            MetricConverter converter = new();
            Assert.That(converter.Convert(value, newUnit), Is.EqualTo(expectedValue));
        }

        [Test]
        public void UnsupportedUnit()
        {
            MetricConverter converter = new();
            Assert.That(() =>
            {
                converter.Convert(1.1, "unknown");
            },
            Throws.TypeOf<ArgumentException>());
        }
    }
}
