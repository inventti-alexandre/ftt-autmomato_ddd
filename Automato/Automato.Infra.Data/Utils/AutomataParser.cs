using Automato.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Automato.Infra.Data.Utils
{
    public class AutomataParser
    {
        public static Automata FromTextLines(IEnumerable<string> lines)
        {
            if (lines.Count() < 6)
                throw new ArgumentException("O automato informado não está completo.");

            var automata = new Automata(
                    lines.ElementAt(1).Split(','),
                    lines.ElementAt(2).Split(','),
                    lines.ElementAt(3),
                    lines.ElementAt(4).Split(',')
                );

            var transitions = lines.Skip(5);
            foreach (var transition in transitions)
            {
                if (transition.Contains("####"))
                    break;
                else
                    automata.AddTransition(TransitionParser.FromTextLine(transition));
            }

            return automata;
        }
    }
}