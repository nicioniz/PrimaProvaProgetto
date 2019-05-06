using PrimaProvaProgetto.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaProvaProgetto.Model
{
    public class Prenotazione
    {
        private string _nome;
        private string _numeroTelefono;
        private int _numeroCoperti;

        public Prenotazione(string nome, string numeroTelefono, int numeroCoperti)
        {
            Nome = nome;
            NumeroTelefono = numeroTelefono;
            NumeroCoperti = numeroCoperti;
        }

        [Editabile]
        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("nome is null or empty");
                _nome = value;
            }
        }

        [Editabile]
        public string NumeroTelefono
        {
            get
            {
                return _numeroTelefono;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("numeroTelefono is null or empty");
                _numeroTelefono = value;
            }
        }

        [Editabile(Modifier = typeof(IntModifier))]
        public int NumeroCoperti
        {
            get
            {
                return _numeroCoperti;
            }

            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("numeroCoperti <= 0");
                _numeroCoperti = value;
            }
        }

        public override string ToString()
        {
            return Nome + " (" + NumeroTelefono + ") Posti: " + NumeroCoperti;
        }
    }
}
