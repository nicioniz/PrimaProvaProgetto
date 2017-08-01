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
    public partial class CategoriaModifier : UserControl
    {
        public CategoriaModifier()
        {
            InitializeComponent();
            foreach (string cat in Enum.GetNames(typeof(Categoria)))
            {
                RadioButton rb = new RadioButton();
                rb.Name = "_" + cat + "RadioButton";
                rb.Text = cat;
                rb.Tag = Enum.Parse(typeof(Categoria), cat);
                tableLayoutPanel1.Controls.Add(rb);
                tableLayoutPanel1.RowCount++;
            }
            
        }

        public Categoria Checked
        {
            get
            {
                foreach (RadioButton rb in tableLayoutPanel1.Controls.OfType<RadioButton>())
                    if (rb.Checked)
                        return (Categoria)rb.Tag;
                return Categoria.Antipasto;
            }

            set
            {
                ((RadioButton)(tableLayoutPanel1.Controls.Find("_" + value.ToString() + "RadioButton", true)[0])).Checked = true;
            }
        }
    }
}
