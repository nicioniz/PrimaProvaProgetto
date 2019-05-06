using PrimaProvaProgetto.Model;
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
    public partial class FirstWindowForm : Form
    {
        
        public FirstWindowForm()
        {
            InitializeComponent();

            //NON permette il ridimensionamento
            MaximumSize = Size;
            MinimumSize = Size;
            
        }

        public Button LayoutButton
        {
            get { return _sceltaLayoutButton; }
        }

        public Button MenuButton
        {
            get { return _sceltaMenuButton; }
        }

        public Button AvvioTotemClientiButton
        {
            get { return _avviaTotemButton; }
        }
    }
}
