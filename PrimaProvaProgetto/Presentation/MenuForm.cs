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
            
            
            PietanzaControl pc;
            bool dis = true;
            for(int i = 0; i < 10; i++)
            {
                pc = new PietanzaControl();
                pc.Pietanza = new Pietanza("nomepietanza" + i, 10.0m, Categoria.Primo, new List<Allergene>(), disponibile: dis);
                dis = !dis;
                tableLayoutPanel1.Controls.Add(pc);
                tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;

                tableLayoutPanel1.Update();
            }
            

        }
    }
}
