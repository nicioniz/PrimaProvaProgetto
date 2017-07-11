using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    interface ICriterioDiSelezione
    {
        List<Pietanza> GetPietanze();
    }
}
