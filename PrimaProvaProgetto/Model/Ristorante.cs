using PrimaProvaProgetto.Persistance;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    public class Ristorante
    {
        private List<Pietanza> _menu;
        private ObservableCollection<Prenotazione> _listaPrenotazioni;
        private List<Allergene> _allergeni;
        private List<Tavolo> _tavoli;

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

        public List<Tavolo> Tavoli
        {
            get
            {
                return _tavoli;
            }

            set
            {
                _tavoli = value;
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
            Menu = MenuPersisterFactory.GetMenuLoader("SimpleMenuLoader").Load();
            ListaPrenotazioni = new ObservableCollection<Prenotazione>();
            Tavoli = LayoutPersisterFactory.GetLayoutLoader("SimpleJsonLayoutLoader").Load(TipoLayout.Vuoto);
            Allergeni = LoadAllergeni();
            //possiamo mettere il caricamento da file
            
            ListaPrenotazioni.CollectionChanged += ListaPrenotazioniChanged;
        }        

        public static Ristorante GetInstance()
        {
            if (_instance == null)
                _instance = new Ristorante();
            return _instance;
        }

        private List<Allergene> LoadAllergeni()
        {
            List<Allergene> res = new List<Allergene>();
            /*
             * fonte:
             * http://gruppomaurizi.it/allergeni-ristoranti/
             */
            res.Add(new Allergene("Glutine"));
            res.Add(new Allergene("Uova"));
            res.Add(new Allergene("Crostacei"));
            res.Add(new Allergene("Pesce"));
            res.Add(new Allergene("Arachidi"));
            res.Add(new Allergene("Frutta a guscio"));
            res.Add(new Allergene("Soia"));
            res.Add(new Allergene("Sedano"));
            res.Add(new Allergene("Lattosio"));
            res.Add(new Allergene("Senape"));
            res.Add(new Allergene("Sesamo"));
            res.Add(new Allergene("Lupini"));
            res.Add(new Allergene("Molluschi"));

            return res;
        }

    }
}
