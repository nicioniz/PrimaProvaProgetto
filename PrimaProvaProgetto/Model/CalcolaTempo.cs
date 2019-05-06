using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    public class CalcolaTempo
    {
        private int _numeroPosti;
        private DateTime _oraInizioPasto;

        public CalcolaTempo(int numeroPosti)
        {
            _numeroPosti = numeroPosti;
        }

        public TimeSpan TempoRimanente
        {
            get
            {
                if (_numeroPosti == 0)
                    return TimeSpan.Zero;
                TimeSpan tempoPrevisto = Previsione.GetInstance().OttieniPrevisione(_numeroPosti);
                TimeSpan tempoRimanente = (_oraInizioPasto + tempoPrevisto) - DateTime.Now;
                return tempoRimanente > TimeSpan.Zero ? tempoRimanente : TimeSpan.Zero;
            }
        }

        public void OccupaTavolo()
        {
            _oraInizioPasto = DateTime.Now;
        }

        public void LiberaTavolo()
        {
            Previsione.GetInstance().InserisciTempoPermanenza(new TempoPermanenza(_numeroPosti, _oraInizioPasto, DateTime.Now));
            //porcata: così quando libero il tavolo alle richieste successive otterrò 0 come tempo
            _numeroPosti = 0;
        }        
    }
}
