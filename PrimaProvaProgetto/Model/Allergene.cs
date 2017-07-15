using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    public class Allergene
    {
        private string _nome;

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value ?? string.Empty;
            }
        }

        public Allergene(String nome)
        {
            Nome = nome;
        }

        public Allergene() : this(null) { }

        public override string ToString()
        {
            return Nome;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Allergene))
                return false;
            return (obj as Allergene).Nome.Equals(Nome);
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }
    }
}
