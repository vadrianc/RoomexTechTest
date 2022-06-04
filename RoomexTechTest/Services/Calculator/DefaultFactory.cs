namespace RoomexTechTestApi.Services.Calculator
{
    public class DefaultFactory : CalculatorFactoryBase
    {
        public override ICalculator GetCalculator(string type)
        {
            return new DefaultCalculator();
        }
    }
}
