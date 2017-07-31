using PrimaProvaProgetto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Tests
{
    class MoneyTest
    {
        public static void Test()
        {
            Money m1 = new Money(1.3m);
            Money m2 = 3.5m;

            Console.WriteLine("---------- MONEY TEST ----------");
            Console.WriteLine("m1 = " + m1);
            Console.WriteLine("m2 = " + m2);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("m1 == m2 --> " + (m1 == m2));
            Console.WriteLine("m1 == 1.3 --> " + (m1 == 1.3m));
            Console.WriteLine("m2 == 3.5 --> " + (m2 == 3.5m));
            Console.WriteLine("m1 == 10 --> " + (m1 == 10m));
            Console.WriteLine("--------------------------------");
        } 

    }
}
