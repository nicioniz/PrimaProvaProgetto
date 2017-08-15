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
    public partial class InserimentoPrenotazioneForm : Form
    {
        public InserimentoPrenotazioneForm()
        {
            InitializeComponent();
        }

        private void _buttonOK_Click(object sender, EventArgs e)
        {
            if (_textBoxNome.Text == "" || _textBoxNumeroTel.Text == "" || _numericUpDownNumeroPosti.Value == 0)
                MessageBox.Show(
                    "Uno o più campi sono errati. Impossibile inserire prenotazione",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            else
            {
                Ristorante.GetInstance().ListaPrenotazioni.Add(
                    new Prenotazione(_textBoxNome.Text, _textBoxNumeroTel.Text, (int)_numericUpDownNumeroPosti.Value));
                MessageBox.Show(
                    "Prenotazione inserita con successo",
                    "Prenotazione inserita",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                Close();
            }
        }

        private void _buttonAnnulla_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
