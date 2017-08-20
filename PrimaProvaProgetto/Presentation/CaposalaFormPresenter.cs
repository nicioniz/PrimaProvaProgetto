using PrimaProvaProgetto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace PrimaProvaProgetto.Presentation
{
    class CaposalaFormPresenter
    {
        private CaposalaForm _target;
        private Ristorante _ristorante;
        /*
         * NOTE:
         * Ci sono alcune ripetizioni di codice, al momento non sono riuscito a trovare una soluzione migliore
         * in quanto dinamicamente popolo la lista e se cerco di risalire al numero di tavolo in altre parti del codice
         * (es: subito dopo aver caricato il layout) non ottengo il risultato cercato.
         * Al momento la grafica delle prenotazioni è completamente funzionante, cliccando sullo spazio bianco
         * compare il menu di inserimento nuova prenotazione, cliccando su una voce della lista invece quello di modifica/elimina.
         * 
         * La grafica dei tavoli funziona ma per ora è scollegata dallo scheduling delle prenotazioni ai tavoli e aggiornamento 
         * della lista 
         */
        public CaposalaFormPresenter(CaposalaForm target)
        {
            _target = target;
            _ristorante = Ristorante.GetInstance();
            _ristorante.ListaPrenotazioni.CollectionChanged += RefreshPrenotazioni;

            foreach (Tavolo t in _ristorante.Tavoli)
            {
                t.StatoChanged += RefreshTavoli;
            }

            //Se per errore si chiude la finestra alla riapertura si hanno le prenotazioni di prima, idem per i tavoli
            RefreshPrenotazioni(this, EventArgs.Empty);
            RefreshTavoli(this, EventArgs.Empty);
        }

        private void RefreshTavoli(object sender, EventArgs e)
        {
            ListView.ListViewItemCollection lista = _target.GetListTavoli.Items;

            if (lista.Count != 0)
            {
                foreach (ListViewItem l in lista)
                {
                    lista.Remove(l);
                }
            }

            foreach (Tavolo t in _ristorante.Tavoli)
            {
                t.Numero = _ristorante.Tavoli.IndexOf(t) + 1;
                ListViewItem lv = new ListViewItem();
                lv.ForeColor = (t.Stato.Equals(StatoTavolo.Occupato)) ? System.Drawing.Color.Red : System.Drawing.Color.Green;
                lv.Tag = t;
                lv.Text = t.ToString();
                lista.Add(lv);
            }
        }

        private void RefreshPrenotazioni(object sender, EventArgs e)
        {
            //prima soluzione di refresh, un po' barbara ma fa il suo dovere
            ListView.ListViewItemCollection lista = _target.GetListView.Items;
            if (lista.Count != 0)
            {
                foreach (ListViewItem i in lista)
                    lista.Remove(i);
            }
            foreach (Prenotazione p in _ristorante.ListaPrenotazioni)
            {
                ListViewItem lv = new ListViewItem();
                lv.Tag = p;
                lv.Text = p.ToString();
                lista.Add(lv);
            }
        }
    }
}
