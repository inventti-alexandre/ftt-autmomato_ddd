using System;
using System.Collections.Generic;
using System.Linq;
using Automato.Application.Entities;
using Automato.Application.Repositories;

namespace Automato.Application.Extensions
{
    public static class AutomataRepositoryExtension
    {
        public static void IsValidAutomataData(this AutomataRepository automataRepository, IEnumerable<string> automataData, string message)
        {
            if (automataData.Count() < 6)
                throw new ArgumentException(message);
        }

        public static Automata Parse(this AutomataRepository automataRepositoty, IEnumerable<string> automataData)
        {
            automataRepositoty.IsValidAutomataData(automataData, "O automato informado não está completo ou não está em um formato válido.");

            var automata = new Automata(
                    automataData.ElementAt(1).Split(','),
                    automataData.ElementAt(2).Split(','),
                    automataData.ElementAt(3),
                    automataData.ElementAt(4).Split(',')
                );

            var transitions = automataData.Skip(5);
            foreach (var transition in transitions)
            {
                if (transition.Contains("####"))
                    break;
                else
                    automata.AddTransition(automataRepositoty.TransitionParse(transition));
            }

            return automata;
        }

        private static void IsValidTransitionData(this AutomataRepository automataRepositoty, IEnumerable<string> transitionData, string message)
        {
            if (transitionData.Count() != 3)
                throw new ArgumentException(message);
        }

        private static Transition TransitionParse(this AutomataRepository automataRepositoty, string transition)
        {
            var t = transition.Split(',');
            automataRepositoty.IsValidTransitionData(t, "A função de transição informada não está completa ou não está em um formato válido.");
            return new Transition(t[0], t[1], t[2]);
        }
    }
}