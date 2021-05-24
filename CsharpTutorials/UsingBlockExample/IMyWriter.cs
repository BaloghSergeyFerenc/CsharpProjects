using System;

namespace UsingBlockExample
{
    internal interface IMyWriter : IDisposable
    {
        void WriteInt(int number);
        void WriteString(string number);
    }
}
