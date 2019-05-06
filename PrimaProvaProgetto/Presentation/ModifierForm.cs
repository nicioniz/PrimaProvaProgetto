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
    public partial class ModifierForm : Form
    {
        public ModifierForm()
        {
            InitializeComponent();
        }

        public Button OkButton
        {
            get { return _okButton; }
        }

        public Button IndietroButton
        {
            get { return _cancelButton; }
        }

        public TableLayoutPanel PropertiesPanel
        {
            get { return tableLayoutPanel1; }
        }
    }
}
