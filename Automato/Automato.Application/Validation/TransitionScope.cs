using Automato.App.Entities;
using System.Collections.Generic;

namespace Automato.App.Validation
{
    public static class TransitionScope
    {
        public static void ParseTransitionDataScopeValidate(this Transition transition, IEnumerable<string> strData)
        {
            AssertionConcern.CollectionLengthBiggerThan(strData, 3, "A função de transição é inválida.");
        }

        public static void RegisterTransitionDataScopeValidate(this Transition transition, IEnumerable<string> states, IEnumerable<string> alphabet)
        {
            AssertionConcern.CollectionContains(states, transition.StartState, "O estado inicial da função de transição não está contido nos estados possívels do automato, ou não foi informado.");
            AssertionConcern.CollectionContains(states, transition.EndState, "O estado final da função de transição não está contido nos estados possívels do automato, ou não foi informado.");
            AssertionConcern.CollectionContains(alphabet, transition.Symbol, "O simbolo informado para a função de transição não está contido no alfabeto definido para o automato.");
        }
    }
}