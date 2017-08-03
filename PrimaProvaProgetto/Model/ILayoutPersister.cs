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
        void Save(List<Tavolo> layout);
    }

    interface ILayoutLoader
    {
        List<Tavolo>  Load(TipoLayout tipo);
    }

    public enum TipoLayout
    {
        Default = 1,
        Ultimo = 2,
        Vuoto = 3
    }
    
}
