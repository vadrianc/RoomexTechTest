using RoomexTechTestApi.Infrastructure.Calculator;

namespace RoomexTechTestApiTest.Infrastructure.Calculator.Mock
{
    internal class BodyFactoryMock : BodyFactoryBase
    {
        public override CalculatorFactoryBase GetFactory(string body)
        {
            return new CalculatorFactoryMock();
        }
    }
}
