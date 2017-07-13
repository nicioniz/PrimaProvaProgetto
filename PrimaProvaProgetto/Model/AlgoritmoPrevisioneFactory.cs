using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    class AlgoritmoPrevisioneFactory
    {
        private static readonly Dictionary<string, IAlgoritmoPrevisione> _dictionary;

        static AlgoritmoPrevisioneFactory ()
        {
            /* popolamento del dizionario:
             * cerco nell'assembly tutti i tipi che
             * implementano l'interfaccia IAlgoritmoPrevisione
             * e ne implemento una istanza che metto nel
             * dizionario.
             * come chiave uso il nome
             */
            _dictionary = new Dictionary<string, IAlgoritmoPrevisione>();
            Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => (type.GetInterface("IAlgoritmoPrevisione") != null))
                .ToList()
                .ForEach(type => _dictionary.Add(
                    type.Name,
                    (IAlgoritmoPrevisione)type.GetConstructor(Type.EmptyTypes).Invoke(Type.EmptyTypes)));

        }

        public static IAlgoritmoPrevisione GetAlgoritmoPrevisione(string nome)
        {
            if (!_dictionary.ContainsKey(nome))
                throw new ArgumentException(nome);
            return _dictionary[nome];
        }

        public static List<string> getAlgoritmiDisponibili()
        {
            return _dictionary.Keys.ToList<string>();
        }

    }
}
