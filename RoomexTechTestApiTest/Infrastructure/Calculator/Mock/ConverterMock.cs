using RoomexTechTestApi.Infrastructure.MeasurementUnit;

namespace RoomexTechTestApiTest.Infrastructure.Calculator.Mock
{
    internal class ConverterMock : IUnitConverter
    {
        public double Convert(double input, string newUnit)
        {
            return input * 3;
        }
    }
}
