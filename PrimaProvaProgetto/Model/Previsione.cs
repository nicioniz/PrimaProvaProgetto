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
            //metto il default
            _algoritmo = AlgoritmoPrevisioneFactory.GetAlgoritmoPrevisione("AlgoritmoPrevisioneSemplice");
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
