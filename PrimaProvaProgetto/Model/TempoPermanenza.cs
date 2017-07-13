using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    class TempoPermanenza
    {
        private int _numeroCoperti;
        private DateTime _oraInizio;
        private DateTime _oraFine;

        public TempoPermanenza(int numeroCoperti, DateTime oraInizio, DateTime oraFine)
        {
            if (numeroCoperti <= 0)
                throw new ArgumentException("numeroCopert <= 0");
            if (oraInizio == null)
                throw new ArgumentNullException("oraInizio is null");
            if (oraFine == null)
                throw new ArgumentNullException("oraFine is null");
            if (oraFine <= oraInizio)
                throw new ArgumentException("oraFine <= oraInizio");
            NumeroCoperti = numeroCoperti;
            OraInizio = oraInizio;
            OraFine = oraFine;
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

        public DateTime OraInizio
        {
            get
            {
                return _oraInizio;
            }

            set
            {
                _oraInizio = value;
            }
        }

        public DateTime OraFine
        {
            get
            {
                return _oraFine;
            }

            set
            {
                _oraFine = value;
            }
        }
    }
}
