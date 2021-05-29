using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger l1 = Logger.Initialize();
            l1.WriteLine("I am");
            l1.WriteNumber(18);
            l1.WriteLine("year old");
            Console.WriteLine(l1.Information);
            Console.ReadKey();
        }
    }
}