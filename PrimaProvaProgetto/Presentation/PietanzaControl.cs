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
        }

        public bool Disponibile
        {
            get
            {
                return _disponibileCheckBox.Checked;
            }
        }
    }
}
