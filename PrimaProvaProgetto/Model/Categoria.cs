using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    [Flags]
    enum Categoria
    {
        Antipasto = 1,
        Primo = 2,
        Secondo = 4,
        Contorno = 8,
        Dolce = 16,
        Bevanda = 32
    }
}
