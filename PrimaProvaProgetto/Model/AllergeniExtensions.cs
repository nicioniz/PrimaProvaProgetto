using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    public static class AllergeniExtensions
    {
        public static Allergene GetAllergene(this List<Allergene> allergeni, string nome)
        {
            return allergeni.Find(a => a.Nome == nome);
        }
    }
}
