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

            Target.ResumeLayout(false);
        }

        private void DrawPietanze()
        {
            Target.TableLayoutPanel.Controls.Clear();
            foreach (Pietanza p in Ristorante.GetInstance().Menu)
                InsertPietanza(p);

            _modifierForm = new ModifierForm();
            _modifierFormPresenter = new ModifierFormPresenter(_modifierForm);

            Target.IndietroButton.Click += buttonIndietro_Click;
            Target.NuovaPietanzaButton.Click += buttonNuovaPietanza_Click;
        }

        private void buttonNuovaPietanza_Click(object sender, EventArgs e)
        {
            Pietanza newPietanza = new Pietanza("", 0m, Categoria.Antipasto, new List<Allergene>());
            _modifierFormPresenter.SetEditableObject(newPietanza);
            if(_modifierForm.ShowDialog() == DialogResult.OK)
            {
                InsertPietanza(newPietanza);
                Ristorante.GetInstance().Menu.Add(newPietanza);
            }

        }

        private void buttonIndietro_Click(object sender, EventArgs e)
        {
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
            DialogResult dr = MessageBox.Show("Sei sicuro di voler eliminare la pietanza " + toDelete.Titolo + "?",
                "Conferma Eliminazione",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
                Ristorante.GetInstance().Menu.Remove(toDelete);
            DrawPietanze();
        }
    }
}
