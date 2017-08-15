using Newtonsoft.Json;
using PrimaProvaProgetto.Presentation;
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

        [JsonConstructor]
        public Tavolo(int postiMax, StatoTavolo stato)
        {
            PostiMax = postiMax;
            Stato = stato;
        }

        // Forse si potrebbe anche togliere questo costruttore, visto che i coperti andranno settati
        // nel momento in cui i clienti si accomodano
        public Tavolo(int coperti, int postiMax, StatoTavolo stato)
        {
            Coperti = coperti;
            PostiMax = postiMax;
            Stato = stato;
        }


        [Editabile(Modifier = typeof(IntModifier))]
        public int Coperti
        {
            get { return _coperti; }
            set { if (Stato.Equals(StatoTavolo.Occupato) && value <= 0) throw new ArgumentException("Invalid seats number"); _coperti = value; _calcolaTempo = new CalcolaTempo(value); }
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
    }
}

