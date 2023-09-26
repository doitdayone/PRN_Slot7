using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Slot7.Ex3
{
    public delegate void MyDelegate(string msg);
    class MyClass
    {
        public static void Print(string message) => Console.WriteLine(message.ToUpper());
        public static void Show(string message) => Console.WriteLine($"{message.ToLower()}");
        public static void Display(string message) => Console.WriteLine($"{message}");
    }
    internal class Program
    {
        static void InvokeDelegate(MyDelegate dele, string msg) => dele(msg);
        static void Main(string[] args)
        {
            string msg = "Multicast Delegate";
            MyDelegate MyDelegate1 = MyClass.Print;
            MyDelegate MyDelegate2 = MyClass.Show;
            Console.WriteLine("***Combines MyDele01 + MyDele02***");
            MyDelegate MyDelegate = MyDelegate1 + MyDelegate2;
            MyDelegate(msg);
            Console.WriteLine("***Combines MyDele01 + MyDele02 + MyDele3***");
            MyDelegate MyDelegate3 = MyClass.Display;
            MyDelegate += MyDelegate3;
            MyDelegate(msg);
            Console.WriteLine("***Remove MyDele02***");
            MyDelegate -= MyDelegate2;
            MyDelegate("Hello World");
            Console.ReadLine();
        }
    }
}