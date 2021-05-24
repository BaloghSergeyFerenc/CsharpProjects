namespace EventsAndDelegates
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CalculationRequestHandler handler = new CalculationRequestHandler();
            CalculationEventProvider provider = new CalculationEventProvider();

            //Addition
            provider.CalculationEvent += handler.MySumEventHandler;
            provider.CalculationRequestHappened(3, 7);

            //Multiplication
            provider.CalculationEvent += handler.MyMultEventHandler;
            provider.CalculationRequestHappened(3, 7);

            //provider.CalculationEvent += handler.Do;
        }
    }
}
