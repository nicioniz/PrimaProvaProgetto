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

        public ListView PrenotazioniListView
        {
            get { return _prenotazioniListView; }
        }

        public ListView TavoliListView
        {
            get { return _tavoliListView; }
        }

        public ToolStripMenuItem OccupaTavoloToolStripMenuItem
        {
            get { return occupaTavoloToolStripMenuItem; }
        }

        public ToolStripMenuItem LiberaTavoloToolStripMenuItem
        {
            get { return liberaTavoloToolStripMenuItem; }
        }

        public ToolStripMenuItem ModificaPrenotazioneToolStripMenuItem
        {
            get { return modificaPrenotazioneToolStripMenuItem; }
        }

        public ToolStripMenuItem EliminaPrenotazioneToolStripMenuItem
        {
            get { return eliminaPrenotazioneToolStripMenuItem; }
        }

        public ToolStripMenuItem InserisciNuovaPrenotazioneToolStripMenuItem
        {
            get { return inserisciNuovaPrenotazioneToolStripMenuItem; }
        }

        public ContextMenuStrip TavoliContextMenuStrip
        {
            get { return _tavoliContextMenuStrip; }
        }

        public ContextMenuStrip PrenotazioniContextMenuStrip
        {
            get { return _prenotazioniContextMenuStrip; }
        }

        public ContextMenuStrip InserisciPrenotazioneContextMenuStrip
        {
            get { return _insertPrenotazioneMenu; }
        }
    }
}
