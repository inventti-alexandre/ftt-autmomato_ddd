using System.Collections.Generic;

namespace Automato.Validation
{
    public static class TrasitionAssertion
    {
        public static void Validate(this Transition transition, IEnumerable<string> validStates, IEnumerable<string> validAlphabet)
        {
            // valida o estado incial da função de transição com base nos estados do automato
            transition.StartState.IsNotNull("O estado inicial da função de transição deve ser informado.");
            transition.StartState.IsValidState(validStates, "O estado inicial informado para a função de transição não está contido nos estados definidos no automato.");

            // valida o simbolo com base no alfabeto do automato
            transition.Symbol.IsNotNull("A função de transição não pode receber um símbolo nulo.");
            transition.Symbol.IsValidSymbol(validAlphabet, "O simbolo informado para a função de transição não está contido no alfabeto definido para o automato.");

            // valida o estado final da função de transição com base nos estados do automato
            transition.EndState.IsNotNull("O estado final da função de transição deve ser informado.");
            transition.EndState.IsValidState(validStates, "O estado final informado para a função de transição não está contido nos estados definidos no automato.");
        }
    }
}