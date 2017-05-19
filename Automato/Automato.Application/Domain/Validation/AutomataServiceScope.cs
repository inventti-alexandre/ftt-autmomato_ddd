using Automato.App.Domain.Entities;
using Automato.App.Services;

namespace Automato.App.Domain.Validation
{
    public static class AutomataServiceScope
    {
        public static void RegisterAutomataScopeValidate(this AutomataService automataService, Automata automata)
        {
            AssertionConcern.CollectionContains(automata.States, automata.Q0, "O estado inicial informado para o automato não é válido.");
            AssertionConcern.CollectionNotEmpty(automata.States, "Você deve informar no mínimo um estado para o automato.");
            AssertionConcern.CollectionNotEmpty(automata.Alphabet, "O alfabeto informado deve conter no mínimo um símbolo.");
            AssertionConcern.CollectionNotEmpty(automata.F, "Você deve informar no mínimo um estado FINAL para o automato.");
            AssertionConcern.CollectionContains(automata.States, automata.F, "Um ou mais estados finais não são válido.");
        }
    }
}
