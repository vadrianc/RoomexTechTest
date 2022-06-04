namespace RoomexTechTestApi.Infrastructure.Calculator
{
    public class DefaultFactory : CalculatorFactoryBase
    {
        public override ICalculator GetCalculator(string type)
        {
            return new DefaultCalculator();
        }
    }
}
