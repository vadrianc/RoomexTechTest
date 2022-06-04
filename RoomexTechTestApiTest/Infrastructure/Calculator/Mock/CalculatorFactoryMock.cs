using RoomexTechTestApi.Infrastructure.Calculator;

namespace RoomexTechTestApiTest.Infrastructure.Calculator.Mock
{
    internal class CalculatorFactoryMock : CalculatorFactoryBase
    {
        public override ICalculator GetCalculator(string type)
        {
            return new DefaultCalculatorMock();
        }
    }
}
