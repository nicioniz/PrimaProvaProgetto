using PrimaProvaProgetto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaProvaProgetto.Presentation
{
    static class DataGridViewExtensions
    {
        public static void ViewMenu(this DataGridView dataGridView, List<Pietanza> menu)
        {
            dataGridView.DataSource = menu;
            dataGridView.Columns["Descrizione"].Visible = false;
            dataGridView.Columns["Disponibile"].Visible = false;
            dataGridView.Columns["Categoria"].Visible = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.Columns["Titolo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["Prezzo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
