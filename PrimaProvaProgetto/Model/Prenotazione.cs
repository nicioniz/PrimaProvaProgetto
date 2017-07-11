using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    class Prenotazione
    {
        private string _nome;
        private string _numeroTelefono;
        private int _numeroCoperti;

        public Prenotazione(string nome, string numeroTelefono, int numeroCoperti)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentNullException("nome is null or empty");
            if (string.IsNullOrEmpty(numeroTelefono))
                throw new ArgumentNullException("numeroTelefono is null or empty");
            if (numeroCoperti <= 0)
                throw new ArgumentOutOfRangeException("numeroCoperti <= 0");
            Nome = nome;
            NumeroTelefono = numeroTelefono;
            NumeroCoperti = numeroCoperti;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public string NumeroTelefono
        {
            get
            {
                return _numeroTelefono;
            }

            set
            {
                _numeroTelefono = value;
            }
        }

        public int NumeroCoperti
        {
            get
            {
                return _numeroCoperti;
            }

            set
            {
                _numeroCoperti = value;
            }
        }

        public override string ToString()
        {
            return Nome + " (" + NumeroTelefono + ") Posti: " + NumeroCoperti;
        }
    }
}
