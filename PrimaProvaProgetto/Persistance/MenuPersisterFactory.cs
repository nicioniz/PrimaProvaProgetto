using Newtonsoft.Json;
using PrimaProvaProgetto.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Persistance
{
    class MenuPersisterFactory
    {

        private static readonly Dictionary<string, IMenuSaver> _saver;
        private static readonly Dictionary<string, IMenuLoader> _loader;

        static MenuPersisterFactory()
        {
            /* popolamento dei dizionari:
             * come nella factory degli algoritmi di previsione
             */
            _saver = new Dictionary<string, IMenuSaver>();
            Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => (type.GetInterface("IMenuSaver") != null))
                .ToList()
                .ForEach(type => _saver.Add(
                    type.Name,
                    (IMenuSaver)type.GetConstructor(Type.EmptyTypes).Invoke(Type.EmptyTypes)));

            _loader = new Dictionary<string, IMenuLoader>();
            Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => (type.GetInterface("IMenuLoader") != null))
                .ToList()
                .ForEach(type => _loader.Add(
                    type.Name,
                    (IMenuLoader)type.GetConstructor(Type.EmptyTypes).Invoke(Type.EmptyTypes)));
        }

        public static IMenuLoader GetMenuLoader(string nome)
        {
            if (!_loader.ContainsKey(nome))
                throw new ArgumentException(nome);
            return _loader[nome];
        }

        public static IMenuSaver GetMenuSaver(string nome)
        {
            if (!_saver.ContainsKey(nome))
                throw new ArgumentException(nome);
            return _saver[nome];
        }
    }

    /*
     * Non salva il il prezzo, quindi non è proprio funzionante 
     */
    class SimpleMenuLoader : IMenuLoader
    {
        public List<Pietanza> Load()
        {
            List<Pietanza> res = null;
            try
            {
                using (StreamReader r = new StreamReader("menu.json"))
                {
                    string json = r.ReadToEnd();
                    res = JsonConvert.DeserializeObject<List<Pietanza>>(json);
                }
            }
            catch (FileNotFoundException)
            {
                //aggiungere finestra di errore??
            }

            return (res == null) ? (new List<Pietanza>()) : (res);
        }
    }

    class SimpleMenuSaver : IMenuSaver
    {
        public void Save(List<Pietanza> menu)
        {
            try
            {
                using (StreamWriter w = new StreamWriter("menu.json"))
                {
                    string json = JsonConvert.SerializeObject(menu);
                    w.Write(json);
                }
            }
            catch
            {
            }
        }
    }

}
