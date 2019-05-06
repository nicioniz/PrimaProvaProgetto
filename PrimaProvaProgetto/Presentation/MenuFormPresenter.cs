using PrimaProvaProgetto.Model;
using PrimaProvaProgetto.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaProvaProgetto.Presentation
{ 
    class MenuFormPresenter
    {
        private MenuForm _target;
        private ModifierForm _modifierForm;
        private ModifierFormPresenter _modifierFormPresenter;

        public MenuFormPresenter(MenuForm target)
        {
            _target = target;
            Target.SuspendLayout();

            DrawPietanze();
            
            Target.IndietroButton.Click += buttonIndietro_Click;
            Target.NuovaPietanzaButton.Click += buttonNuovaPietanza_Click;


            _modifierForm = new ModifierForm();
            _modifierFormPresenter = new ModifierFormPresenter(_modifierForm);

            Target.ResumeLayout(false);
        }

        private void DrawPietanze()
        {
            Target.TableLayoutPanel.Controls.Clear();
            foreach (Pietanza p in LocaleRistorazione.GetInstance().Menu)
                InsertPietanza(p);
        }

        private void buttonNuovaPietanza_Click(object sender, EventArgs e)
        {
            Pietanza newPietanza = new Pietanza("", 0m, Categoria.Antipasto, new List<Allergene>());
            _modifierFormPresenter.SetEditableObject(newPietanza);
            if(_modifierForm.ShowDialog() == DialogResult.OK)
            {
                InsertPietanza(newPietanza);
                LocaleRistorazione.GetInstance().Menu.Add(newPietanza);
            }

        }

        private void buttonIndietro_Click(object sender, EventArgs e)
        {
            if(LocaleRistorazione.GetInstance().Menu.Where(p => p.Disponibile == true).ToList().Count == 0)
            {
                MessageBox.Show(
                "Il menu non contiene pietanze disponibili, non sarà possibile avviare il totem clienti",
                "Nessuna Pietanza",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }

            Target.Close();
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            _modifierFormPresenter.SetEditableObject(((ToolStripMenuItem)sender).Tag);
            _modifierForm.ShowDialog();
        }

        public MenuForm Target
        {
            get
            {
                return _target;
            }
        }

        private void InsertPietanza(Pietanza p)
        {
            PietanzaControl pc = new PietanzaControl();
            pc.Pietanza = p;
            Target.TableLayoutPanel.Controls.Add(pc, 0, Target.TableLayoutPanel.RowCount++ - 2);
            pc.Modifica.Click += buttonModifica_Click;
            pc.Elimina.Click += buttonElimina_Click;
        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            Pietanza toDelete = (Pietanza)((ToolStripMenuItem)sender).Tag;
            DialogResult dr = MessageBox.Show(
                "Sei sicuro di voler eliminare la pietanza " + toDelete.Titolo + "?",
                "Conferma Eliminazione",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
                LocaleRistorazione.GetInstance().Menu.Remove(toDelete);
            DrawPietanze();
        }
    }
}
