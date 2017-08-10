using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    interface ILayoutSaver
    {
        void Save(Dictionary<String,Tavolo> layout);
    }

    interface ILayoutLoader
    {
        Dictionary<String, Tavolo>  Load(TipoLayout tipo);
    }

    public enum TipoLayout
    {
        Default = 1,
        Ultimo = 2,
        Vuoto = 3
    }
    
}
