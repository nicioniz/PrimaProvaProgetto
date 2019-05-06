using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    public class Previsione
    {
        private static Previsione _instance;

        private List<TempoPermanenza> _tempiPermanenza;
        private IAlgoritmoPrevisione _algoritmo;

        private Previsione()
        {
            _tempiPermanenza = new List<TempoPermanenza>();

            //popoliamo già la lista di tempi di permanenza in modo da poter avere già qualche previsione
            _tempiPermanenza = LoadTempiPermanenza();
            

            //metto il default
            _algoritmo = AlgoritmoPrevisioneFactory.GetAlgoritmoPrevisione("AlgoritmoPrevisioneSemplice");
        }

        private List<TempoPermanenza> LoadTempiPermanenza()
        {
            List<TempoPermanenza> res = new List<TempoPermanenza>();

            res.Add(new TempoPermanenza(2,
                new DateTime(2017, 7, 1, 19, 0, 0),
                new DateTime(2017, 7, 1, 19, 45, 0)));

            res.Add(new TempoPermanenza(3,
                new DateTime(2017, 7, 1, 19, 10, 0),
                new DateTime(2017, 7, 1, 20, 0, 0)));

            res.Add(new TempoPermanenza(5,
                new DateTime(2017, 7, 1, 19, 10, 0),
                new DateTime(2017, 7, 1, 20, 30, 0)));

            res.Add(new TempoPermanenza(1,
                new DateTime(2017, 7, 1, 19, 15, 0),
                new DateTime(2017, 7, 1, 19, 30, 0)));

            res.Add(new TempoPermanenza(7,
                new DateTime(2017, 7, 1, 20, 30, 0),
                new DateTime(2017, 7, 1, 22, 45, 0)));

            res.Add(new TempoPermanenza(6,
                new DateTime(2017, 7, 1, 21, 0, 0),
                new DateTime(2017, 7, 1, 22, 35, 0)));

            res.Add(new TempoPermanenza(8,
                new DateTime(2017, 7, 1, 21, 0, 0),
                new DateTime(2017, 7, 1, 23, 0, 0)));

            return res;
        }

        public static Previsione GetInstance()
        {
            if (_instance == null)
                _instance = new Previsione();
            return _instance;
        }

        public List<string> GetAlgoritmiDisponibili()
        {
            return AlgoritmoPrevisioneFactory.GetAlgoritmiDisponibili();
        }

        public void SetAlgoritmoPrevisione(string nome)
        {
            _algoritmo = AlgoritmoPrevisioneFactory.GetAlgoritmoPrevisione(nome);
        }

        public TimeSpan OttieniPrevisione(int numeroPersone)
        {
            return _algoritmo.OttieniPrevisione(_tempiPermanenza, numeroPersone);
        }

        public void InserisciTempoPermanenza(TempoPermanenza tp)
        {
            _tempiPermanenza.Add(tp);
        }
    }
}
