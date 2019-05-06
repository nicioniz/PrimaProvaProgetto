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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        public TableLayoutPanel TableLayoutPanel
        {
            get
            {
                return tableLayoutPanel1;
            }
        }

        public Button IndietroButton
        {
            get
            {
                return _indietroButton;
            }
        }

        public Button NuovaPietanzaButton
        {
            get
            {
                return _newPietanzaButton;
            }
        }
    }
}
