using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    static class CriterioDiSelezioneBuilder
    {
        public static ICriterioDiSelezione GetCriterio(List<Categoria> categorie, List<Allergene> allergeni)
        {
            Categoria categoriaMaschera = 0;
            categorie.ForEach(cat => categoriaMaschera = categoriaMaschera | cat);
            ICriterioDiSelezione res = new CriterioDiSelezioneByDisp();
            res = new CriterioDiSelezioneByCategoria(categoriaMaschera, res);
            allergeni.ForEach(all => res = new CriterioDiSelezioneByNotContainsAllergene(all, res));
            return res;
        }
    }
}
