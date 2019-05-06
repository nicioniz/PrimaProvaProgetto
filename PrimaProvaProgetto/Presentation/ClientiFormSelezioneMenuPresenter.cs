using PrimaProvaProgetto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaProvaProgetto.Presentation
{
    class ClientiFormSelezioneMenuPresenter
    {
        private ClientiForm _target;

        public ClientiFormSelezioneMenuPresenter(ClientiForm target)
        {
            _target = target;

            Target.SelezioneChanged += Target_SelezioneChanged;
            Target.MenuDataGridView.ViewMenu(new CriterioDiSelezioneByDisp().GetPietanze());
            Target.ToolTipTextNeeded += Target_ToolTipTextNeeded;
        }

        private void Target_ToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            //se non viene dalla casella del nome
            //oppure viene dalla riga di intestazione
            if (e.ColumnIndex != 0 || e.RowIndex == -1)
                return;
            else
                e.ToolTipText = GetToolTipText(e.RowIndex);
        }

        private void Target_SelezioneChanged(object sender, EventArgs e)
        {
            ICriterioDiSelezione criterio = CriterioDiSelezioneBuilder.GetCriterio(Target.CategorieSelezionate, Target.AllergeniSelezionati);
            Target.MenuDataGridView.ViewMenu(criterio.GetPietanze());
        }

        public ClientiForm Target
        {
            get
            {
                return _target;
            }
        }

        private string GetToolTipText(int row)
        {
            DataGridViewRow element = Target.MenuDataGridView.Rows[row];
            return element.Cells["Categoria"].Value + Environment.NewLine + Environment.NewLine + element.Cells["Descrizione"].Value;
        }
    }
}
