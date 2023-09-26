using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Slot7.NewFolder1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Tai", "Hoang", "Khoa", "An", "Hung" };
            foreach (string name in names.OrderBy(s=>s)) { Console.WriteLine(name); }

            var items = from word in names
                        where word.Contains("n")
                        select word;
            foreach(string s in items) { Console.WriteLine(s);}

            Console.ReadLine();
        }
    }
}
