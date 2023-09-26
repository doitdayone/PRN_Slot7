using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Slot7.Ex5
{
    public delegate void PrintDetails(string msg);
    internal class Program
    {
        event PrintDetails Print;
        void Show(string msg)=> Console.WriteLine(msg.ToUpper());
        static void Main(string[] args)
        {
            Program p = new Program();

            p.Print += new PrintDetails(p.Show);

            p.Print("Hello World");
            Console.ReadLine();
        }
    }
}
