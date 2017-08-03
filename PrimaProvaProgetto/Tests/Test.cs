using PrimaProvaProgetto.Model;
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
        Pietanza piet = new Pietanza("primissimo piatto",
                4.5m, Categoria.Antipasto, new List<Allergene>());
        Prenotazione pren = new Prenotazione("NomeCognome1", "123 4567890", 5);

        List<Pietanza> pietanze = new List<Pietanza>();

        public Test()
        {
            InitializeComponent();
            //CategoriaModifier cm = new CategoriaModifier();
            //cm.Checked = Categoria.Contorno;
            //Controls.Add(cm);

            //Categoria a = cm.Checked;

            //AllergeniModifier am = new AllergeniModifier();
            //List<Allergene> all = new List<Allergene>();
            //all.Add(Ristorante.GetInstance().Allergeni.GetAllergene("Lattosio"));
            //all.Add(Ristorante.GetInstance().Allergeni.GetAllergene("Senape"));
            //am.Allergeni = all;
            //Controls.Add(am);

            //List<Allergene> la = am.Allergeni;

            //Controls.Add(new MoneyModifier());

            for (int i = 0; i < 10; i++)
            {
                Pietanza p = new Pietanza(
                    "Piatto" + i,
                    3m + (decimal)i,
                    Categoria.Contorno,
                    new List<Allergene>(),
                    "descrizione" + i,
                    i % 2 == 1);
                pietanze.Add(p);
            }

            textBox1.Text = piet.ToString();
            textBox2.Text = pren.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModifierForm f = new ModifierForm();
            ModifierFormPresenter mfp = new ModifierFormPresenter(f);
            
            mfp.SetEditableObject(piet);
            if(f.ShowDialog() == DialogResult.OK)
                textBox1.Text = piet.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModifierForm f = new ModifierForm();
            ModifierFormPresenter mfp = new ModifierFormPresenter(f);

            mfp.SetEditableObject(pren);
            if (f.ShowDialog() == DialogResult.OK)
                textBox2.Text = pren.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MenuForm mf = new MenuForm();
            mf.Show();
            foreach(Pietanza p in pietanze)
            {
                PietanzaControl pc = new PietanzaControl();
                pc.Pietanza = p;
                mf.TableLayoutPanel.Controls.Add(pc, 0, mf.TableLayoutPanel.RowCount++ - 1);
                pc.Modifica.Click += buttonModifica_Click;
            }
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            ModifierForm f = new ModifierForm();
            ModifierFormPresenter mfp = new ModifierFormPresenter(f);

            mfp.SetEditableObject(((ToolStripMenuItem)sender).Tag);
            f.ShowDialog();
        }
    }
}
