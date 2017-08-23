
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using PrimaProvaProgetto.Model;

namespace PrimaProvaProgetto.Presentation
{
    class CaposalaFormPresenter
    {
        private CaposalaForm _target;
        private LocaleRistorazione _localeRistorazione;
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

        private ModifierForm _modifierForm;
        private ModifierFormPresenter _modifierFormPresenter;


        public CaposalaFormPresenter(CaposalaForm target)
        {
            _target = target;
            _localeRistorazione = LocaleRistorazione.GetInstance();
            _localeRistorazione.ListaPrenotazioni.CollectionChanged += RefreshPrenotazioni;

            foreach (Tavolo t in _localeRistorazione.Tavoli)
            {
                t.StatoChanged += RefreshTavoli;
            }

            //Se per errore si chiude la finestra alla riapertura si hanno le prenotazioni di prima, idem per i tavoli
            RefreshPrenotazioni(this, EventArgs.Empty);
            RefreshTavoli(this, EventArgs.Empty);

            _modifierForm = new ModifierForm();
            _modifierFormPresenter = new ModifierFormPresenter(_modifierForm);


            _target.PrenotazioniListView.MouseClick += _prenotazioniListView_MouseClick;
            _target.PrenotazioniListView.MouseDown += _prenotazioniListView_MouseDown;
            _target.TavoliListView.MouseClick += _tavoliListView_MouseClick;
            _target.OccupaTavoloToolStripMenuItem.Click += occupaTavoloToolStripMenuItem_Click;
            _target.LiberaTavoloToolStripMenuItem.Click += liberaTavoloToolStripMenuItem_Click;
            _target.ModificaPrenotazioneToolStripMenuItem.Click += modificaPrenotazioneToolStripMenuItem_Click;
            _target.EliminaPrenotazioneToolStripMenuItem.Click += eliminaPrenotazioneToolStripMenuItem_Click;
            _target.InserisciNuovaPrenotazioneToolStripMenuItem.Click += inserisciNuovaPrenotazioneToolStripMenuItem_Click;

            _target.FineSerataButton.Click += FineSerataButton_Click;

        }

        private void FineSerataButton_Click(object sender, EventArgs e)
        {
            if (_localeRistorazione.Tavoli.FindAll(t => t.Stato == StatoTavolo.Occupato).Count > 0)
            {
                DialogResult dr = MessageBox.Show(
                    "Impossibile terminare la serata, ci sono ancora " + _localeRistorazione.Tavoli.FindAll(t => t.Stato == StatoTavolo.Occupato).Count + " tavoli occupati. Liberare i tavoli e riprovare.",
                    "Fine serata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                DialogResult dr = MessageBox.Show(
                    "Sei sicuro di voler terminare la serata?",
                    "Fine serata",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.Yes)
                        Application.Exit();
            }
        }

        private void RefreshTavoli(object sender, EventArgs e)
        {
            ListView.ListViewItemCollection lista = _target.TavoliListView.Items;

            if (lista.Count != 0)
            {
                foreach (ListViewItem l in lista)
                {
                    lista.Remove(l);
                }
            }

            foreach (Tavolo t in _localeRistorazione.Tavoli)
            {
                t.Numero = _localeRistorazione.Tavoli.IndexOf(t) + 1;
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
            ListView.ListViewItemCollection lista = _target.PrenotazioniListView.Items;
            if (lista.Count != 0)
            {
                foreach (ListViewItem i in lista)
                    lista.Remove(i);
            }
            foreach (Prenotazione p in _localeRistorazione.ListaPrenotazioni)
            {
                ListViewItem lv = new ListViewItem();
                lv.Tag = p;
                lv.Text = p.ToString();
                lista.Add(lv);
            }
        }

        private void _tavoliListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (_target.TavoliListView.FocusedItem.Selected)
                {
                    _target.TavoliContextMenuStrip.Tag = _target.TavoliListView.FocusedItem;
                    _target.TavoliContextMenuStrip.Items[0].Enabled = ((Tavolo)_target.TavoliListView.FocusedItem.Tag).Stato.Equals(StatoTavolo.Libero);
                    _target.TavoliContextMenuStrip.Items[1].Enabled = ((Tavolo)_target.TavoliListView.FocusedItem.Tag).Stato.Equals(StatoTavolo.Occupato);
                    _target.TavoliContextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void _prenotazioniListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListView lv = (ListView)sender;
                if (lv.FocusedItem.Selected)
                {
                    _target.PrenotazioniContextMenuStrip.Tag = lv.FocusedItem;
                    _target.PrenotazioniContextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void modificaPrenotazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem t = (ToolStripMenuItem)sender;
            ListViewItem lvi = (ListViewItem)t.GetCurrentParent().Tag;
            Prenotazione p = (Prenotazione)lvi.Tag;
            ObservableCollection<Prenotazione> lista = LocaleRistorazione.GetInstance().ListaPrenotazioni;


            int index = lvi.ListView.Items.IndexOf(lvi);
            _modifierFormPresenter.SetEditableObject(p);

            if (_modifierForm.ShowDialog() == DialogResult.OK)
            {
                lista.RemoveAt(index);
                lista.Insert(index, p);
            }
        }

        private void eliminaPrenotazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem t = (ToolStripMenuItem)sender;
            ListViewItem lvi = (ListViewItem)t.GetCurrentParent().Tag;
            Prenotazione p = (Prenotazione)lvi.Tag;
            LocaleRistorazione.GetInstance().ListaPrenotazioni.Remove(p);
            MessageBox.Show("Cancellazione Effettuata", "Elimina");
        }

        //unico handler per occupa e libera tavolo, differenzio il cambio in base allo stato del tavolo cliccato
        private void occupaTavoloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem t = (ToolStripMenuItem)sender;
            ListViewItem lvi = (ListViewItem)t.GetCurrentParent().Tag;
            LocaleRistorazione r = LocaleRistorazione.GetInstance();
            Tavolo tav = (Tavolo)lvi.Tag;

            int index = lvi.ListView.Items.IndexOf(lvi);

            Prenotazione first = getPrenotazione();
            bool vuota = false;

            if (first == null)
            {
                vuota = true;
            }

            if (!vuota && first.NumeroCoperti <= tav.PostiMax)
            {
                r.Tavoli.ElementAt(index).Stato = StatoTavolo.Occupato;
                r.Tavoli.ElementAt(index).Numero = r.Tavoli.IndexOf(r.Tavoli.ElementAt(index)) + 1;
                r.Tavoli.ElementAt(index).Coperti = first.NumeroCoperti;
                r.Tavoli.ElementAt(index).CalcolaTempo.OccupaTavolo();
                r.ListaPrenotazioni.Remove(first);

                MessageBox.Show("Cliente " + first.ToString() + " al " + r.Tavoli.ElementAt(index));
            }
        }

        private Prenotazione getPrenotazione()
        {
            //return (Ristorante.GetInstance().ListaPrenotazioni.Count != 0) ? Ristorante.GetInstance().ListaPrenotazioni.First() : null;
            if (LocaleRistorazione.GetInstance().ListaPrenotazioni.Count == 0)
            {
                MessageBox.Show("Nessuna voce nella lista prenotazioni");
                return null;
            }
            if (_target.PrenotazioniListView.SelectedItems.Count != 1)
            {
                MessageBox.Show("Seleziona una voce dalla lista di prenotazione");
                return null;
            }
            return (Prenotazione)_target.PrenotazioniListView.SelectedItems[0].Tag;
        }

        private void _prenotazioniListView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListView lv = (ListView)sender;
                if (lv.CheckedItems.Count == 0)
                {
                    _target.InserisciPrenotazioneContextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void inserisciNuovaPrenotazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InserimentoPrenotazioneForm().Show();
        }

        private void liberaTavoloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem t = (ToolStripMenuItem)sender;
            ListViewItem lvi = (ListViewItem)t.GetCurrentParent().Tag;
            LocaleRistorazione r = LocaleRistorazione.GetInstance();
            Tavolo tav = (Tavolo)lvi.Tag;

            tav.CalcolaTempo.LiberaTavolo();
            tav.Stato = StatoTavolo.Libero;
            tav.Numero = r.Tavoli.IndexOf(tav) + 1;
            MessageBox.Show(tav.ToString());
        }
    }

}

