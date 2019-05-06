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

            // Setto il componente per i coperti
            _numericUpDownNumeroPosti.Minimum = 1;
            List<Tavolo> tavoli = LocaleRistorazione.GetInstance().Tavoli;
            int maxPosti = 2;
            foreach (Tavolo t in tavoli)
            {
                if (t.PostiMax > maxPosti)
                {
                    maxPosti = t.PostiMax;
                }
            }
            _numericUpDownNumeroPosti.Maximum = maxPosti;
            _numericUpDownNumeroPosti.ReadOnly = true;
        }

        private void _buttonOK_Click(object sender, EventArgs e)
        {
            if (_textBoxNome.Text == "" || _textBoxNumeroTel.Text == "" || !telefonoValido(_textBoxNumeroTel.Text))
                MessageBox.Show(
                    "Uno o più campi sono errati. Impossibile inserire prenotazione",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            else
            {
                LocaleRistorazione.GetInstance().ListaPrenotazioni.Add(
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

        private Boolean telefonoValido(String telefono)
        {
            for (int i = 0; i < telefono.Length; i++)
            {
                if (i == 0)
                {
                    if (!telefono[i].Equals('+') && !Char.IsDigit(telefono[i]))
                        return false;
                }
                else
                    if (!Char.IsDigit(telefono[i]))
                    return false;
            }
            return true;
        }

        private void _buttonAnnulla_Click(object sender, EventArgs e)
        {
            Close();
        }

        public TextBox GetNomeBox
        {
            get { return _textBoxNome; }
        }
        public TextBox GetTelefonoBox
        {
            get { return _textBoxNumeroTel; }
        }
        public NumericUpDown GetCopertiBox
        {
            get { return _numericUpDownNumeroPosti; }
        }
    }
}
