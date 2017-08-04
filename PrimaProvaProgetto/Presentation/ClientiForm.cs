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
    public partial class ClientiForm : Form
    {
        public ClientiForm()
        {
            InitializeComponent();
            foreach (string cat in Enum.GetNames(typeof(Categoria)))
            {
                CheckBox cb = new CheckBox();
                cb.Name = "_" + cat + "CheckBox";
                cb.Text = cat;
                cb.Tag = Enum.Parse(typeof(Categoria), cat);
                cb.Checked = true;
                cb.CheckedChanged += Cb_CheckedChanged;
                _categorieFlowLayoutPanel.Controls.Add(cb);
            }
            foreach (Allergene all in Ristorante.GetInstance().Allergeni)
            {
                CheckBox cb = new CheckBox();
                cb.Name = "_" + all.Nome + "CheckBox";
                cb.Text = all.Nome;
                cb.Tag = all;
                cb.CheckedChanged += Cb_CheckedChanged;
                _allergeniFlowLayoutPanel.Controls.Add(cb);
            }

            MenuDataGridView.ShowCellToolTips = true;
            MenuDataGridView.CellToolTipTextNeeded += MenuDataGridView_CellToolTipTextNeeded;
        }

        private void MenuDataGridView_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            ToolTipTextNeeded?.Invoke(sender, e);
        }

        private void Cb_CheckedChanged(object sender, EventArgs e)
        {
            OnSelezioneChanged();
        }

        public List<Categoria> CategorieSelezionate
        {
            get
            {
                List<Categoria> res = new List<Categoria>();
                foreach (CheckBox cb in _categorieFlowLayoutPanel.Controls.OfType<CheckBox>())
                    if (cb.Checked)
                        res.Add((Categoria)cb.Tag);
                return res;
            }
        }

        public List<Allergene> AllergeniSelezionati
        {
            get
            {
                List<Allergene> res = new List<Allergene>();
                foreach (CheckBox cb in _allergeniFlowLayoutPanel.Controls.OfType<CheckBox>())
                    if (cb.Checked)
                        res.Add((Allergene)cb.Tag);
                return res;
            }
        }

        public event EventHandler SelezioneChanged;
        public event DataGridViewCellToolTipTextNeededEventHandler ToolTipTextNeeded;

        private void OnSelezioneChanged()
        {
            SelezioneChanged?.Invoke(this, EventArgs.Empty);
        }

        public DataGridView MenuDataGridView
        {
            get { return _menuDataGridView; }
        }
    }
}
