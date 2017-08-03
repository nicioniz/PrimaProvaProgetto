using PrimaProvaProgetto.Presentation;
using PrimaProvaProgetto.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    public class Tavolo
    {
        private CalcolaTempo _calcolaTempo;
        private int _coperti;
        private int _postiMax;
        private StatoTavolo _stato;

        [Editabile(Modifier = typeof(IntModifier))]
        public int Coperti
        {
            get { return _coperti; }
            set { if (value <= 0) throw new ArgumentException("Invalid seats number"); _coperti = value;}
        }

        [Editabile(Modifier = typeof(IntModifier))]
        public int PostiMax
        {
            get { return _postiMax; }
            set { if (value <= 0) throw new ArgumentException("Invalid max seats number"); _postiMax = value; }
        }

        public CalcolaTempo CalcolaTempo
        {
            get { return _calcolaTempo; }
            set { _calcolaTempo = value;}
        }

        public StatoTavolo Stato
        {
            get { return _stato; }
            set { _stato = value;}
        }


        public Tavolo(int coperti, int postimax, StatoTavolo stato)
        {  
            Coperti = coperti;
            PostiMax = postimax;
            Stato = stato;
        }

    }
}

