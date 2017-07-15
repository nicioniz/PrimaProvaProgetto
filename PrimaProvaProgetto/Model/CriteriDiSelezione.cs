using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    /* 
     * Uso del pattern DECORATOR:
     * Ogni criterio di selezione può contenere al suo
     * interno un ulteriore criterio di selezione.
     * Si parte da quello che restituisce tutto il menù
     * e sopra questo si andranno ad innestare i vari 
     * criteri che saranno in AND logico fra di loro
     * 
     * Per selezionare più categorie ogni categoria è in OR
     * logico con le altre. Per questo motivo non posso
     * innestare vari selettori di categoria.
     * Avendo però definito la categoria come enumerativo 
     * flag, posso definire nel costruttore del selettore
     * l'OR bit a bit dei valori dell'enumerativo
     * Per esempio, per selezionare tutti i primi e i secondi
     * passo come categoria:
     *     "Categoria.Primo | Categoria.Secondo"
     */

    public class CriterioDiSelezioneAll : ICriterioDiSelezione
    {
        public List<Pietanza> GetPietanze()
        {
            return Ristorante.GetInstance().Menu;
        }
    }

    public class CriterioDiSelezioneBase : ICriterioDiSelezione
    {
        private Func<Pietanza, bool> _predicate;
        private ICriterioDiSelezione _innerCriterio;

        public CriterioDiSelezioneBase(Func<Pietanza, bool> predicate, ICriterioDiSelezione innerCriterio)
        {
            _predicate = predicate;
            _innerCriterio = innerCriterio;
            if (_innerCriterio == null)
                _innerCriterio = new CriterioDiSelezioneAll();
        }

        public CriterioDiSelezioneBase(Func<Pietanza, bool> predicate)
            : this(predicate, null) { }

        public List<Pietanza> GetPietanze()
        {
            return _innerCriterio.GetPietanze().Where(_predicate).ToList();
        }
    }

    public class CriterioDiSelezioneByCategoria : CriterioDiSelezioneBase
    {
        public CriterioDiSelezioneByCategoria(Categoria categoria)
            : base(p => categoria.HasFlag(p.Categoria)) { }

        public CriterioDiSelezioneByCategoria(Categoria categoria, ICriterioDiSelezione innerCriterio)
            : base(p => categoria.HasFlag(p.Categoria), innerCriterio) { }
    }

    public class CriterioDiSelezioneByNotContainsAllergene : CriterioDiSelezioneBase
    {
        public CriterioDiSelezioneByNotContainsAllergene(Allergene allergene)
            : base(p => !p.Allergeni.Contains(allergene)) { }

        public CriterioDiSelezioneByNotContainsAllergene(Allergene allergene, ICriterioDiSelezione innerCriterio)
            : base(p => !p.Allergeni.Contains(allergene), innerCriterio) { }
    }

    public class CriterioDiSelezioneByDisp : CriterioDiSelezioneBase
    {
        public CriterioDiSelezioneByDisp()
            : base(p => p.Disponibile) { }

        public CriterioDiSelezioneByDisp(ICriterioDiSelezione innerCriterio)
            : base(p => p.Disponibile, innerCriterio) { }
    }

}
