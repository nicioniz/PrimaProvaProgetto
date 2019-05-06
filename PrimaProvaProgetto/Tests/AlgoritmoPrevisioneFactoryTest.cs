using PrimaProvaProgetto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Tests
{
    class AlgoritmoPrevisioneFactoryTest
    {
        public static void Test()
        {
            Console.WriteLine("---------- ALGORITMO PREVISIONE FACTORY TEST ----------");
            List<string> lista = AlgoritmoPrevisioneFactory.GetAlgoritmiDisponibili();
            foreach (string a in lista)
                Console.WriteLine(a);

            IAlgoritmoPrevisione alg = AlgoritmoPrevisioneFactory.GetAlgoritmoPrevisione("AlgoritmoPrevisioneSemplice");

            List<TempoPermanenza> tps = new List<TempoPermanenza>();

            DateTime adesso = DateTime.Now;

            tps.Add(new TempoPermanenza(2, adesso, adesso + new TimeSpan(0, 30, 0)));
            tps.Add(new TempoPermanenza(2, adesso, adesso + new TimeSpan(0, 45, 0)));
            tps.Add(new TempoPermanenza(2, adesso, adesso + new TimeSpan(1, 0, 0)));

            TimeSpan ts = alg.OttieniPrevisione(tps, 2);

            Console.WriteLine(ts.TotalMinutes);
            Console.WriteLine("--------------------------------");
        }
    }
    
}
