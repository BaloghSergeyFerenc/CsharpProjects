namespace EventsAndDelegates
{
    internal class CalculationRequestHandler
    {
        public string MySumEventHandler(int a, int b)
        {
            return $"Restult of sum: {a + b}";
        }

        public string MyMultEventHandler(int c, int d)
        {
            return $"Restult of sum: {c * d}";
        }

        public string Do(int a) { return ""; }
    }
}
