using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingBlockExample
{
    class Program
    {
        private static void Main(string[] args)
        {
            FirstUse();

            SecondUse();

            ThirdUse();
        }

        private static void FirstUse()
        {
            using (IMyWriter myWriter = new MyWriter(@"D:\abc.txt"))
            {
                myWriter.WriteInt(5);
                myWriter.WriteInt(9);
            }
        }

        private static void SecondUse()
        {
            using (IMyWriter myWriter = new MyWriter(@"D:\abc.txt"))
            {
                myWriter.WriteInt(5);
                myWriter.WriteInt(9);
            }
        }

        private static void ThirdUse()
        {
            using (IMyWriter myWriter = new MyWriter(@"D:\def.txt"))
            {
                myWriter.WriteInt(5);
                myWriter.WriteInt(9);
            }
        }
    }
}
