using PrimaProvaProgetto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Tests
{
    class CriteriDiSelezioneTest
    {
        public static void Test()
        {
            Ristorante rist = Ristorante.GetInstance();
            List<Allergene> allergeniLasagne = new List<Allergene>();
            allergeniLasagne.Add(new Allergene("Latticini"));
            rist.Menu.Add(new Pietanza("Lasagna alla bolognese", 7.5m, Categoria.Primo, allergeniLasagne));

            rist.Menu.Add(new Pietanza("Prosciutto e melone", 5.0m, Categoria.Antipasto, null, "Un antipasto fresco", false));

            rist.Menu.Add(new Pietanza("Arrosto di lonza di maiale al latte", 8.0m, Categoria.Secondo, allergeniLasagne, "Un secondo classico"));

            rist.Menu.Add(new Pietanza("Pignoletto bottiglia", 5.0m, Categoria.Bevanda, null));

            Console.WriteLine("---------- CRITERI DI SELEZIONE TEST ----------");

            Console.WriteLine("---------- MENU COMPLETO ----------");
            rist.Menu.ForEach(p => Console.WriteLine(p + Environment.NewLine));

            Console.WriteLine("---------- MENU NO LATTICINI ----------");
            new CriterioDiSelezioneByNotContainsAllergene(new Allergene("Latticini"))
                .GetPietanze()
                .ForEach(p => Console.WriteLine(p + Environment.NewLine));

            Console.WriteLine("---------- MENU SOLO PRIMI E SECONDI ----------");
            new CriterioDiSelezioneByCategoria(Categoria.Primo | Categoria.Secondo)
                .GetPietanze()
                .ForEach(p => Console.WriteLine(p + Environment.NewLine));

            Console.WriteLine("---------- MENU SOLO DISPONIBILI ----------");
            new CriterioDiSelezioneByDisp()
                .GetPietanze()
                .ForEach(p => Console.WriteLine(p + Environment.NewLine));

            Console.WriteLine("---------- MENU SOLO PRIMI NO LATTICINI ----------");
            new CriterioDiSelezioneByCategoria(Categoria.Primo,
                    new CriterioDiSelezioneByNotContainsAllergene(new Allergene("Latticini")))
                .GetPietanze()
                .ForEach(p => Console.WriteLine(p + Environment.NewLine));

        }

    }
}
