using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaProvaProgetto.Presentation
{
    public partial class LayoutForm : Form
    {
        public LayoutForm()
        {
            InitializeComponent();
            this.Text = "Scelta Layout";
        }

        /* NOTE: 
         * 
         * Per realizzare la griglia della view ho sfruttato dei tableLayoutPanel sui quali ho poi applicato un pannello (sulla destra) e la griglia (a sinistra).
         * In quello di sinistra ho realizzato una matrice di PictureBox, sono dei controlli adatti ad ospitare immagini al loro interno
         * e ai quali si è vincolati per realizzare delle operazioni di drag'n'drop di immagini (ho provato alternative ma con risultati negativi)
         * Ogni PictureBox ha gli handler di riferimento associati (vedi note di sotto) e ho impostato la risoluzione in modo che l'immagine sia "stretchata" al suo interno, prima dal designer e poi aggiungendo
         * con i foreach i metodi giusti ciclando per gruppi di PictureBox (del layout di destra o di sinistra...)
         * Le pictureBox della griglia hanno i nomi con le enumerazioni della cella in cui si trovano nella matrice (es: _pictureBoxLayout11 è in riferimento alla riga 1 e colonna 1 della matrice)
         * 
         * 
         * Ho definito due gruppi di nomi di metodi:
         * -> _2postiPictureBox è il riferimento per tutte le pictureBox di destra (da notare nel designer l'associazione a tutta questa categoria di metodi e anche tramite delegati nel codice)
         * -> _pictureBoxLayout11 è il riferimento per tutte le pictureBox di sinistra.
         * 
         * Li ho differenziati poichè per quelle di destra è prevista una copia delle immagini e effetto zoom al mouseEnter
         * in quelle di sinistra invece ho previsto uno spostamento dell'immagine (copio alla destinazione e cancello la sorgente) così il cliente si vede il tavolo spostato
         * cosa che per quelli di destra invece non è giusto fare... 
         * 
         * COSE MANCANTI:
         * Gestione dei tavoli posizionati sul layout (lista o array) sul quale intervenire con le operazioni di modifica e/o salvataggio del layout (va qui o nel presenter?)
         * Gestione dei tre pulsanti e funzionalità annesse.
         */

        private void LayoutForm_Load(object sender, EventArgs e)
        {
            //Handler per i pictureBox di destra, ad ogni drag viene fatta una copia dell'immagine
            IEnumerable<PictureBox> tavoliBox = panel1.Controls.OfType<PictureBox>();
            foreach (PictureBox pb in tavoliBox)
            {
                pb.AllowDrop = true;

                pb.MouseDown += new MouseEventHandler(_2postiPictureBox_MouseDown);
                pb.DragEnter += new DragEventHandler(_2postiPictureBox_DragEnter);
                pb.DragDrop += new DragEventHandler(_2postiPictureBox_DragDrop);
            }


            //Handler per i pictureBox di sinistra, ad ogni drag viene spostata l'immagine e cancellata
            //quella della pictureBox di partenza 
            IEnumerable<PictureBox> layoutBox = tableLayoutPanel2.Controls.OfType<PictureBox>();
            foreach (PictureBox pb in layoutBox)
            {
                pb.AllowDrop = true;
                pb.MouseDown += new MouseEventHandler(_pictureBoxLayout11_MouseDown);
                pb.DragEnter += new DragEventHandler(_pictureBoxLayout11_DragEnter);
                pb.DragDrop += new DragEventHandler(_pictureBoxLayout11_DragDrop);
            }
        }


        // L'evento indica il rilascio del pulsante del mouse (quindi sottintende 
        //la fine dell'operazione di drop dell'immagine
        private void _2postiPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Select();
            if (pb.Image != null)
            {
                pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
            }
        }

        //L'evento DragEnter viene triggerato quando un oggetto entra all'interno
        //dei confini di un determinato controllo (nel nostro caso la pictureBox
        //che ospita le immagini dei tavoli
        private void _2postiPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        //Evento triggerato quando viene completata l'operazione di trascinamento
        private void _2postiPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void _pictureBoxLayout11_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Select();
            if (pb.Image != null)
            {
                pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
                pb.Image = null;
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    MessageBox.Show("Tavolo Eliminato");
                    //
                    //qui bisogna eliminare il tavolo da una lista dei tavoli aggiunti
                    //nel presenter bisogna registrarsi ad un evento che triggera l'inserimento
                    //in una lista dei tavoli trascinati
                    //
                }
            }
        }

        private void _pictureBoxLayout11_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void _pictureBoxLayout11_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        //Qui gestisco il cambio di cursore sulle pictureBox di destra
        private void _2postiPictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Cursor = Cursors.Hand;
        }

        //Qui gestisco il cambio di cursore sulle pictureBox di destra
        private void _2postiPictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Cursor = Cursors.Default;
        }
    }
}
