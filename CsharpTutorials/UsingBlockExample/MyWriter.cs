using System;
using System.IO;

namespace UsingBlockExample
{
    internal class MyWriter : IMyWriter
    {
        private StreamWriter streamWriter;

        public MyWriter(string path)
        {
            streamWriter = new StreamWriter(path, true);
        }

        public void Dispose()
        {
            streamWriter.Dispose();
        }

        public void WriteInt(int number)
        {
            streamWriter.WriteLine(number);
        }

        public void WriteString(string number)
        {
            throw new NotImplementedException();
        }
    }
}
