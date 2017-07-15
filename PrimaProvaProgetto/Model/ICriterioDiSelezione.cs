using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    public interface ICriterioDiSelezione
    {
        List<Pietanza> GetPietanze();
    }
}
