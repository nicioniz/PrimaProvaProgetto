using PrimaProvaProgetto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Persistance
{
    class LayoutPersisterFactory
    {
        private static readonly Dictionary<string, ILayoutSaver> _saver;
        private static readonly Dictionary<string, ILayoutLoader> _loader;

        static LayoutPersisterFactory()
        {
            /* popolamento dei dizionari:
             * come nella factory degli algoritmi di previsione
             */
            _saver = new Dictionary<string, ILayoutSaver>();
            Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => (type.GetInterface("ILayoutSaver") != null))
                .ToList()
                .ForEach(type => _saver.Add(
                    type.Name,
                    (ILayoutSaver)type.GetConstructor(Type.EmptyTypes).Invoke(Type.EmptyTypes)));

            _loader = new Dictionary<string, ILayoutLoader>();
            Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => (type.GetInterface("ILayoutLoader") != null))
                .ToList()
                .ForEach(type => _loader.Add(
                    type.Name,
                    (ILayoutLoader)type.GetConstructor(Type.EmptyTypes).Invoke(Type.EmptyTypes)));
        }

        public static ILayoutLoader GetLayoutLoader(string nome)
        {
            if (!_loader.ContainsKey(nome))
                throw new ArgumentException(nome);
            return _loader[nome];
        }

        public static ILayoutSaver GetLayoutSaver(string nome)
        {
            if (!_saver.ContainsKey(nome))
                throw new ArgumentException(nome);
            return _saver[nome];
        }
    }
}
