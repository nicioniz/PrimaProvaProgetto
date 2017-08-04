using Newtonsoft.Json;
using PrimaProvaProgetto.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Persistance
{
    class SimpleJsonLayoutLoader : ILayoutLoader
    {
        public List<Tavolo> Load(TipoLayout tipo)
        {
            string fileName;
            List<Tavolo> res = null;

            switch (tipo)
            {
                case TipoLayout.Default:
                    fileName = "default.json";
                    break;
                case TipoLayout.Ultimo:
                    fileName = "ultimo.json";
                    break;
                default:
                    return new List<Tavolo>();
            }

            try
            {
                using (StreamReader r = new StreamReader(fileName))
                {
                    string json = r.ReadToEnd();
                    res = JsonConvert.DeserializeObject<List<Tavolo>>(json);
                }
            }
            catch (FileNotFoundException) {}

            return (res == null) ? (new List<Tavolo>()) : (res);
        }
    }

    class SimpleJsonLayoutSaver : ILayoutSaver
    {
        public void Save(List<Tavolo> layout)
        {
            try
            {
                using (StreamWriter w = new StreamWriter("ultimo.json"))
                {
                    string json = JsonConvert.SerializeObject(layout);
                    w.Write(json);
                }
            }
            catch
            {
            }
        }
    }
}
