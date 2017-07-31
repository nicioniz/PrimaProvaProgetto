using PrimaProvaProgetto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Tests
{
    class PietanzaTest
    {
        public static void Test()
        {
            Pietanza[] p = new Pietanza[2];
            p[0] = new Pietanza("Lasagne", 7.5m, Categoria.Primo, null);
            p[1] = new Pietanza("Arrosto", 8.5m, Categoria.Secondo, null, "Arrosto di lonza di maiale al forno", false);

            Console.WriteLine("---------- PIETANZA TEST ----------");

            foreach (Pietanza pietanza in p)
                Console.WriteLine(pietanza + Environment.NewLine);
            Console.WriteLine("--------------------------------");
        }
    }
}
