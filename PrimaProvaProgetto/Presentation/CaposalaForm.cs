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
                if (_tavoliListView.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    _tavoliContextMenuStrip.Items[0].Enabled = _tavoliListView.FocusedItem.Tag.Equals(StatoTavolo.Libero);
                    _tavoliContextMenuStrip.Items[1].Enabled = _tavoliListView.FocusedItem.Tag.Equals(StatoTavolo.Occupato);
                    _tavoliContextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void _prenotazioniListView_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                if (_prenotazioniListView.FocusedItem.Selected)
                {
                    _prenotazioniContextMenuStrip.Tag = _prenotazioniListView.FocusedItem;
                    _prenotazioniContextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void modificaPrenotazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem t = (ToolStripMenuItem)sender;
            ListViewItem lvi = (ListViewItem) t.GetCurrentParent().Tag;
            Prenotazione p = (Prenotazione)lvi.Tag;

            Ristorante.GetInstance().ListaPrenotazioni.Remove(p);
            InserimentoPrenotazioneForm ipf = new InserimentoPrenotazioneForm();
            ipf.GetNomeBox.Text = p.Nome;
            ipf.GetTelefonoBox.Text = p.NumeroTelefono;
            ipf.GetCopertiBox.Value = p.NumeroCoperti;
            ipf.Show();
        }

        private void eliminaPrenotazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem t = (ToolStripMenuItem)sender;
            ListViewItem lvi = (ListViewItem)t.GetCurrentParent().Tag;
            Prenotazione p = (Prenotazione)lvi.Tag;

            Ristorante.GetInstance().ListaPrenotazioni.Remove(p);
            MessageBox.Show("Cancellazione Effettuata", "Elimina");
        }
    }
}
