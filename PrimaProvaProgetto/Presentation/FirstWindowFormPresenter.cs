using PrimaProvaProgetto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaProvaProgetto.Presentation
{
    class FirstWindowFormPresenter
    {
        FirstWindowForm _target;

        public FirstWindowFormPresenter(FirstWindowForm target)
        {
            _target = target;

            Target.LayoutButton.Click += LayoutButton_Click;
            Target.MenuButton.Click += MenuButton_Click;
            Target.AvvioTotemClientiButton.Click += AvvioTotemClientiButton_Click;
            Application.Idle += Application_Idle;
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            Target.AvvioTotemClientiButton.Enabled =
                LocaleRistorazione.GetInstance().Menu.Where(p => p.Disponibile).Count() != 0 &&
                LocaleRistorazione.GetInstance().Tavoli.Count != 0;
        }

        private void AvvioTotemClientiButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Sei sicuro di voler avviare il Totem Clienti?",
                "Conferma Avvio Totem Clienti",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                Target.LayoutButton.Enabled = false;
                Target.MenuButton.Enabled = false;

                //si dovrà lanciare la vista col presenter del totem clienti
                ClientiForm cf = new ClientiForm();
                new ClientiFormSelezioneMenuPresenter(cf);
                new ClientiFormTempiAttesaPresenter(cf);
                cf.Show();



                //e la vista col presenter per il totem del cameriere
                CaposalaForm cpf = new CaposalaForm();
                new CaposalaFormPresenter(cpf);
                cpf.Show();
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            MenuForm mf = new MenuForm();
            new MenuFormPresenter(mf);
            mf.Show();
        }

        private void LayoutButton_Click(object sender, EventArgs e)
        {
            LayoutForm lf = new LayoutForm();
            new LayoutFormPresenter(lf);
            lf.Show();
        }

        public FirstWindowForm Target
        {
            get
            {
                return _target;
            }
        }
    }
}
