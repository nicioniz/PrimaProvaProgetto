using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    class Ristorante
    {
        private List<Pietanza> _menu;
        private ObservableCollection<Prenotazione> _listaPrenotazioni;
        private List<Allergene> _allergeni;

        private static Ristorante _instance = null;

        public List<Pietanza> Menu
        {
            get
            {
                return _menu;
            }

            set
            {
                _menu = value;
            }
        }

        public ObservableCollection<Prenotazione> ListaPrenotazioni
        {
            get
            {
                return _listaPrenotazioni;
            }

            set
            {
                _listaPrenotazioni = value;
            }
        }

        public List<Allergene> Allergeni
        {
            get
            {
                return _allergeni;
            }

            set
            {
                _allergeni = value;
            }
        }

        public event NotifyCollectionChangedEventHandler ListaPrenotazioniChanged;

        private Ristorante()
        {
            Menu = new List<Pietanza>();
            ListaPrenotazioni = new ObservableCollection<Prenotazione>();
            Allergeni = new List<Allergene>();
            //possiamo mettere il caricamento da file
            ListaPrenotazioni.CollectionChanged += ListaPrenotazioniChanged;
        }        

        public static Ristorante GetInstance()
        {
            if (_instance == null)
                _instance = new Ristorante();
            return _instance;
        }

    }
}
