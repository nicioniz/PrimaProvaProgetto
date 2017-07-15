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
        public PietanzaControl(Pietanza p)
        {
            InitializeComponent();
            _pietanza = p;
            Draw();
        }

        public bool Disponibile
        {
            get
            {
                return _disponibileCheckBox.Checked;
            }
        }

        private void Draw()
        {
            _nomeLabel.Text = _pietanza.Titolo;
            _disponibileCheckBox.Checked = _pietanza.Disponibile;
        }

        private void _disponibileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _pietanza.Disponibile = _disponibileCheckBox.Checked;
        }
    }
}
