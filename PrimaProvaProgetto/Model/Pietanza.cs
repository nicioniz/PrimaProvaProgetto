﻿using PrimaProvaProgetto.Presentation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    public class Pietanza
    {
        private string _titolo;
        private string _descrizione;
        private Money _prezzo;
        private bool _disponibile;
        private Categoria _categoria;
        private List<Allergene> _allergeni;

        public event EventHandler Changed;

        public Pietanza(string titolo, Money prezzo, Categoria categoria, List<Allergene> allergeni, string descrizione = "", bool disponibile = true)
        {
            Titolo = titolo;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Disponibile = disponibile;
            Categoria = categoria;
            Allergeni = allergeni;
        }
        
        private void OnChanged()
        {
            Changed?.Invoke(this, EventArgs.Empty);
        }

        [Editabile]
        public string Titolo
        {
            get
            {
                return _titolo;
            }

            set
            {
                if (value == null)
                    throw new ArgumentNullException("titolo");
                _titolo = value;
                OnChanged();
            }
        }

        [Editabile]
        public string Descrizione
        {
            get
            {
                return _descrizione;
            }

            set
            {
                _descrizione = value ?? string.Empty;
                OnChanged();
            }
        }

        [Editabile(Modifier = typeof(MoneyModifier))]
        public Money Prezzo
        {
            get
            {
                return _prezzo;
            }

            set
            {
                _prezzo = value;
                OnChanged();
            }
        }

        public bool Disponibile
        {
            get
            {
                return _disponibile;
            }

            set
            {
                _disponibile = value;
                OnChanged();
            }
        }

        [Editabile(Modifier = typeof(CategoriaModifier))]
        public Categoria Categoria
        {
            get
            {
                return _categoria;
            }

            set
            {
                _categoria = value;
                OnChanged();
            }
        }

        [Editabile(Modifier = typeof(AllergeniModifier))]
        public List<Allergene> Allergeni
        {
            get
            {
                return _allergeni;
            }

            set
            {
                _allergeni = value ?? new List<Allergene>();
                OnChanged();
            }
        }

        public override string ToString()
        {
            return Titolo + Environment.NewLine +
                (string.IsNullOrEmpty(Descrizione) ? "" : Descrizione + Environment.NewLine) +
                (Allergeni.Count == 0 ? "" : StampaAllergeni() + Environment.NewLine) +
                Prezzo;
        }

        private string StampaAllergeni()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Allergeni: ");
            Allergeni.ForEach(a => sb.Append(a.ToString() + " "));
            return sb.ToString();
        }
    }
}
