using Automato.App.Entities;
using Automato.App.Repositories;
using System.Collections.Generic;

namespace Automato.App.Validation
{
    public static class AutomataScope
    {
        public static void RegisterAutomataScopeValidate(this Automata automata)
        {
            AssertionConcern.CollectionContains(automata.States, automata.Q0, "O estado inicial informado para o automato não é válido.");
            AssertionConcern.CollectionNotEmpty(automata.States, "Você deve informar no mínimo um estado para o automato.");
            AssertionConcern.CollectionNotEmpty(automata.Alphabet, "O alfabeto informado deve conter no mínimo um símbolo.");
            AssertionConcern.CollectionNotEmpty(automata.F, "Você deve informar no mínimo um estado FINAL para o automato.");
            AssertionConcern.CollectionContains(automata.States, automata.F, "Um ou mais estados finais não são válido.");
        }

        public static void ParseAutomataDataScopeValidate(this Automata automata, IEnumerable<string> lines)
        {
            AssertionConcern.CollectionLengthBiggerThan(lines, 6, "O automato está incompleto.");
        }
    }
}