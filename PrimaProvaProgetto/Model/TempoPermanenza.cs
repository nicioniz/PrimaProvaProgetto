using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    public class TempoPermanenza
    {
        private int _numeroCoperti;
        private DateTime _oraInizio;
        private DateTime _oraFine;

        public TempoPermanenza(int numeroCoperti, DateTime oraInizio, DateTime oraFine)
        {
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
                if (value <= 0)
                    throw new ArgumentException("numeroCopert <= 0");
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
                if (value == null)
                    throw new ArgumentNullException("oraInizio is null");
                if (OraFine != default(DateTime) && OraFine <= value)
                    throw new ArgumentException("oraFine <= oraInizio");
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
                if (value == null)
                    throw new ArgumentNullException("oraFine is null");
                if (OraInizio != default(DateTime) && value <= OraInizio)
                    throw new ArgumentException("oraFine <= oraInizio");
                _oraFine = value;
            }
        }

        public TimeSpan Tempo
        {
            get
            {
                return OraFine - OraInizio;
            }
        }
    }
}
