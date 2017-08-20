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

            Rectangle resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            if (resolution.Height < Size.Height || resolution.Width < Size.Width)
            {
               
                //La dimenione la riduco ulteriormente per evitare che finisca sotto la barra inferiore
                //(solitamente la gente ha la barra in basso, so che non è il massimo come soluzione)
                Size = new Size(resolution.Width, resolution.Height - 50);

            }

            //NON permette il ridimensionamento
            MaximumSize = Size;
            MinimumSize = Size;
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
