using RoomexTechTestApi.Infrastructure.Calculator;
using RoomexTechTestApi.Model;

namespace RoomexTechTestApiTest.Infrastructure.Calculator.Mock
{
    internal class DefaultCalculatorMock : ICalculator
    {
        public double Process(Point start, Point end)
        {
            return -1;
        }
    }
}
