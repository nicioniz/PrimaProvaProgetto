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
    }
}
