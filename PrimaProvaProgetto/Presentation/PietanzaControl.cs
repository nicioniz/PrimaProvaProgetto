using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimaProvaProgetto.Model;

namespace PrimaProvaProgetto.Presentation
{
    public partial class PietanzaControl : UserControl
    {
        private Pietanza _pietanza;
        public PietanzaControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            
        }

        private void _pietanza_Changed(object sender, EventArgs e)
        {
            Draw();
        }

        public bool Disponibile
        {
            get
            {
                return _disponibileCheckBox.Checked;
            }
        }

        public Pietanza Pietanza
        {
            get
            {
                return _pietanza;
            }

            set
            {
                _pietanza = value;
                _pietanza.Changed += _pietanza_Changed;
                Draw();
            }
        }

        private void Draw()
        {
            _nomeLabel.Text = Pietanza.Titolo;
            _disponibileCheckBox.Checked = Pietanza.Disponibile;
        }

        private void _disponibileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Pietanza.Disponibile = _disponibileCheckBox.Checked;
        }

        
    }
}
