using Automato.Application.Entities;
using System;
using System.Linq;

namespace Automato.Application.Extensions
{
    public static class AutomataExtension
    {
        public static void IsValidQ0State(this Automata automata, string message)
        {
            if (!automata.States.Contains(automata.Q0) ||
                string.IsNullOrWhiteSpace(automata.Q0))
                throw new ArgumentException(message);
        }

        public static void IsValidStates(this Automata automata, string message)
        {
            if (automata.States.Any())
                throw new ArgumentOutOfRangeException(message);
        }

        public static void IsValidAlphabet(this Automata automata, string message)
        {
            if (automata.Alphabet.Any())
                throw new ArgumentOutOfRangeException(message);
        }

        public static void IsValidEndState(this Automata automata, string message)
        {
            if (automata.F.Any(state => !automata.States.Contains(state) || string.IsNullOrWhiteSpace(state)))
            {
                throw new ArgumentException(message);
            }
        }

        public static void IsValidState(this Automata automata, string state, string message)
        {
            if (!automata.States.Contains(state) ||
                string.IsNullOrWhiteSpace(state))
                throw new ArgumentException(message);
        }

        public static void IsValidSymbol(this Automata automata, string symbol, string message)
        {
            if (!automata.Alphabet.Contains(symbol) ||
                string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentException(message);
        }

        public static void IsValidTransition(this Automata automata, Transition transition, string message)
        {
            try
            {
                automata.IsValidState(transition.StartState, "O estado inicial da função de transição não está contido nos estados possívels do automato, ou não foi informado.");
                automata.IsValidState(transition.EndState, "O estado final da função de transição não está contido nos estados possívels do automato, ou não foi informado.");
                automata.IsValidSymbol(transition.Symbol, "O simbolo informado para a função de transição não está contido no alfabeto definido para o automato.");
            }
            catch (Exception e)
            {
                throw new ArgumentException(message, e);
            }
        }

        public static string StateFormat(this Automata automata, string state)
        {
            return state.Trim()
                        .Replace("(", "")
                        .Replace(")", "");
        }

        public static string SymbolFormat(this Automata automata, string symbol)
        {
            return symbol.Trim()
                        .Replace("(", "")
                        .Replace(")", "");
        }
    }
}