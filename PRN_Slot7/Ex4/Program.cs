using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Slot7.Ex4
{
    
    internal class Program
    {
        static int Sum(int a, int b) => a + b;
        static void Print(string msg) => Console.WriteLine(msg.ToUpper());
        static void Main(string[] args)
        {
            int a = 15; int b = 25, s;
            string strResult;

            Func<int, int, int> sumFunc = Sum;
            s = sumFunc(a, b);
            strResult = $"{a} + {b} + {s}";
            Console.WriteLine("***Invoke Print method by Action delegate***");
            Action<string> action = Print;
            action(strResult);
            Console.ReadLine();
        }
    }
}
