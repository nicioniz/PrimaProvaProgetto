using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimaProvaProgetto.Model;
using System.Collections.ObjectModel;

namespace PrimaProvaProgetto.Presentation
{
    public partial class CaposalaForm : Form
    {
        public CaposalaForm()
        {
            InitializeComponent();
        }

        public ListView GetListView
        {
            get { return _prenotazioniListView; }
        }

        public ListView GetListTavoli
        {
            get { return _tavoliListView; }
        }

        private void _tavoliListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (_tavoliListView.FocusedItem.Selected)
                {
                    _tavoliContextMenuStrip.Tag = _tavoliListView.FocusedItem;
                    _tavoliContextMenuStrip.Items[0].Enabled = ((Tavolo)_tavoliListView.FocusedItem.Tag).Stato.Equals(StatoTavolo.Libero);
                    _tavoliContextMenuStrip.Items[1].Enabled = ((Tavolo)_tavoliListView.FocusedItem.Tag).Stato.Equals(StatoTavolo.Occupato);
                    _tavoliContextMenuStrip.Show(Cursor.Position);
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
                    _prenotazioniContextMenuStrip.Tag = lv.FocusedItem;
                    _prenotazioniContextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void modificaPrenotazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem t = (ToolStripMenuItem)sender;
            ListViewItem lvi = (ListViewItem) t.GetCurrentParent().Tag;
            Prenotazione p = (Prenotazione)lvi.Tag;
            ObservableCollection<Prenotazione> lista = Ristorante.GetInstance().ListaPrenotazioni;
            ModifierForm mf = new ModifierForm();
            ModifierFormPresenter mfp = new ModifierFormPresenter(mf);

            int index = lvi.ListView.Items.IndexOf(lvi);
            mfp.SetEditableObject(p);

            if (mf.ShowDialog() == DialogResult.OK)
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
            Ristorante.GetInstance().ListaPrenotazioni.Remove(p);
            MessageBox.Show("Cancellazione Effettuata", "Elimina");
        }

        //unico handler per occupa e libera tavolo, differenzio il cambio in base allo stato del tavolo cliccato
        private void occupaTavoloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem t = (ToolStripMenuItem)sender;
            ListViewItem lvi = (ListViewItem)t.GetCurrentParent().Tag;
            Ristorante r = Ristorante.GetInstance();
            Tavolo tav = (Tavolo)lvi.Tag;
            
            int index = lvi.ListView.Items.IndexOf(lvi);

            r.Tavoli.ElementAt(index).Stato = (tav.Stato.Equals(StatoTavolo.Occupato)) ? StatoTavolo.Libero : StatoTavolo.Occupato;
        }

        private void _prenotazioniListView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListView lv = (ListView)sender;
                if (lv.CheckedItems.Count == 0)
                {
                    Console.WriteLine(lv.CheckedItems.Count);
                    _insertPrenotazioneMenu.Show(Cursor.Position);
                }
            }
        }

        private void inserisciNuovaPrenotazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InserimentoPrenotazioneForm().Show();
        }
    }
}
