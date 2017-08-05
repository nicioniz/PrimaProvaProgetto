using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    public class AlgoritmoPrevisioneSemplice : IAlgoritmoPrevisione
    {
        /*
        * Faccio semplicemente la media delle varie permanenze 
        */
        public TimeSpan OttieniPrevisione(List<TempoPermanenza> vecchiePermanenze, int numeroPersone)
        {
            return new TimeSpan(Convert.ToInt64(
                vecchiePermanenze
                    .Where(tp => tp.NumeroCoperti <= numeroPersone && tp.NumeroCoperti >= (numeroPersone + 1))
                    .Average(tp => tp.Tempo.Ticks)));
        }

    }
}
