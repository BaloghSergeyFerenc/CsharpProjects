namespace DisposePattern
{
    internal delegate void MyDelegate();

    internal class MyEventProvider
    {
        public event MyDelegate MyEvent;
    }
}
