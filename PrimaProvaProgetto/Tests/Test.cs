using PrimaProvaProgetto.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaProvaProgetto.Tests
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            CategoriaModifier cm = new CategoriaModifier();
            cm.Checked = Model.Categoria.Contorno;
            Controls.Add(cm);

            Model.Categoria a = cm.Checked;
        }
    }
}
