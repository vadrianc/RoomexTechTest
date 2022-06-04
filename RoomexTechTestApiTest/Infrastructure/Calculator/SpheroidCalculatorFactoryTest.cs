using RoomexTechTestApi;
using RoomexTechTestApi.Infrastructure.Calculator;
using RoomexTechTestApi.Infrastructure.CustomException;

namespace RoomexTechTestApiTest.Infrastructure.Calculator
{
    internal class SpheroidCalculatorFactoryTest
    {
        [Test]
        public void KnownCalculatorType()
        {
            SpheroidCalculatorFactory factory = new SpheroidCalculatorFactory(Cosmos.Radius.Earth);
            ICalculator calculator = factory.GetCalculator(Cosmos.CalculationMethod.Pythagora);
            Assert.That(calculator, Is.InstanceOf<PythagoreanCalculator>());
        }

        [Test]
        public void UnknownCalculatorType()
        {
            SpheroidCalculatorFactory factory = new SpheroidCalculatorFactory(Cosmos.Radius.Earth);
            Assert.That(
                () => { 
                    factory.GetCalculator("unknown");
                }, 
                Throws.TypeOf<UnknownCalculatorException>());
        }
    }
}
