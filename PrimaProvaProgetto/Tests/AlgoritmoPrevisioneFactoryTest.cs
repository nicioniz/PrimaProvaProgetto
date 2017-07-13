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
            List<string> lista = AlgoritmoPrevisioneFactory.getAlgoritmiDisponibili();
            foreach (string a in lista)
                Console.WriteLine(a);

            //Dictionary<string, IAlgoritmoPrevisione> _dictionary = new Dictionary<string, IAlgoritmoPrevisione>();
            //Assembly.GetExecutingAssembly().GetTypes()
            //    .Where(type => (type.GetInterface("IAlgoritmoPrevisione") != null))
            //    .ToList()
            //    .ForEach(type => _dictionary.Add(type.Name, (IAlgoritmoPrevisione)type.GetConstructor(Type.EmptyTypes).Invoke(Type.EmptyTypes)));
            //_dictionary.Keys.ToList().ForEach(s => Console.WriteLine(s));

            //Assembly.GetExecutingAssembly().GetTypes()
            //    .Where(type => (type.GetInterface("IAlgoritmoPrevisione") != null))
            //    .ToList()
            //    .ForEach(type => Console.WriteLine(type.Name));
        }
    }

    //class prova1 : IAlgoritmoPrevisione
    //{
    //    public prova1() { }
    //    public TimeSpan OttieniPrevisione(List<TempoPermanenza> vecchiePermanenze, int numeroPersone)
    //    {
    //        return new TimeSpan();
    //    }
    //}
    //class prova2 : IAlgoritmoPrevisione
    //{
    //    public prova2() { }
    //    public TimeSpan OttieniPrevisione(List<TempoPermanenza> vecchiePermanenze, int numeroPersone)
    //    {
    //        return new TimeSpan();
    //    }
    //}
    //class prova3 : IAlgoritmoPrevisione
    //{
    //    public prova3() { }
    //    public TimeSpan OttieniPrevisione(List<TempoPermanenza> vecchiePermanenze, int numeroPersone)
    //    {
    //        return new TimeSpan();
    //    }
    //}
}
