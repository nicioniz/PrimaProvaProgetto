using PrimaProvaProgetto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace PrimaProvaProgetto.Presentation
{
    class CaposalaFormPresenter
    {
        private CaposalaForm _target;

        public CaposalaFormPresenter(CaposalaForm target)
        {
            _target = target;
            Ristorante.GetInstance().ListaPrenotazioni.CollectionChanged += RefreshPrenotazioni;

           
            foreach (Tavolo t in Ristorante.GetInstance().Tavoli)
            {
                t.Numero = Ristorante.GetInstance().Tavoli.IndexOf(t) + 1;
                ListViewItem lv = new ListViewItem();
                lv.Text = t.ToString();
                lv.Tag = t.Stato;
                _target.GetListTavoli.Items.Add(lv);
            }
        }

        private void RefreshPrenotazioni(object sender, NotifyCollectionChangedEventArgs e)
        {
            //prima soluzione di refresh, un po' barbara ma fa il suo dovere
            ListView.ListViewItemCollection lista = _target.GetListView.Items;
            if (lista.Count != 0)
            {
                foreach (ListViewItem i in lista)
                    lista.Remove(i);
            }
            foreach (Prenotazione p in Ristorante.GetInstance().ListaPrenotazioni)
            {
                ListViewItem lv = new ListViewItem();
                lv.Tag = p;
                lv.Text = p.ToString();
                lista.Add(lv);
            }
        }
    }
}
