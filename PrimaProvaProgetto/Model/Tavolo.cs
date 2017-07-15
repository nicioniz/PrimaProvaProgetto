using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    class Tavolo
    {
        private int _numeroPersone;
        private int _postiMax;
        private StatoTavolo _prevStato;
        private StatoTavolo _stato;
        private CalcolaTempo _calcolaTempo;

        public int NumeroPersone
        {
            get
            {
                return _numeroPersone;
            }

            set
            {
                _numeroPersone = value;
            }
        }

        public StatoTavolo Stato
        {
            get
            {
                return _stato;
            }

            set
            {
                _prevStato = _stato;
                _stato = value;
            }
        }

        public Tavolo(int postiMax)
        {
            _postiMax = postiMax;
            Stato = StatoTavolo.Libero;
        }

        public void Occupa(int numeroPersone)
        {
            NumeroPersone = numeroPersone;
            Stato = StatoTavolo.Occupato;
            if (_prevStato == StatoTavolo.Libero && _stato == StatoTavolo.Occupato)
                _calcolaTempo = new CalcolaTempo(DateTime.Now, NumeroPersone);
        }

        public void Libera()
        {
            Stato = StatoTavolo.Libero;
            Previsione.GetInstance()
                .InserisciTempoPermanenza(
                    new TempoPermanenza(NumeroPersone, _calcolaTempo.OraInizio, DateTime.Now));
            _calcolaTempo = null;
        }

        public TimeSpan TempoRimanente
        {
            get
            {
                return _calcolaTempo.TempoRimanente;
            }
        }


        class CalcolaTempo
        {
            private DateTime _oraInizio;
            private int _numeroPersone;

            public CalcolaTempo(DateTime oraInizio, int numeroPersone)
            {
                OraInizio = oraInizio;
                NumeroPersone = numeroPersone;
            }
            public CalcolaTempo(DateTime oraInizio)
            {
                OraInizio = oraInizio;
            }

            public TimeSpan TempoRimanente
            {
                get
                {
                    return Previsione.GetInstance().OttieniPrevisione(NumeroPersone) - 
                        (DateTime.Now - OraInizio);
                }
            }

            public int NumeroPersone
            {
                get
                {
                    return _numeroPersone;
                }

                set
                {
                    _numeroPersone = value;
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
        }
    }    
}
