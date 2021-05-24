using System;

namespace EventsAndDelegates
{
    internal delegate string CalculationEventHandler(int x, int y);

    internal class CalculationEventProvider
    {
        public event CalculationEventHandler CalculationEvent;

        public void CalculationRequestHappened(int x, int y)
        {
            //Console.WriteLine(CalculationEvent.Invoke(x, y));
            Console.WriteLine(CalculationEvent(x, y));
        }

    }
}
