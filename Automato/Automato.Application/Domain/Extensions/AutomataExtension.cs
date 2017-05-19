using Automato.App.Domain.Entities;
using Automato.App.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Automato.App.Domain.Extensions
{
    public static class AutomataExtension
    {
        public static Automata Parse(this Automata automata, IEnumerable<string> automataData)
        {
            // valida se o parser pode ser começado
            automata.ParseAutomataDataScopeValidate(automataData);

            var states = automataData.ElementAt(1).Split(',');
            var alphabet = automataData.ElementAt(2).Split(',');
            var q0 = automataData.ElementAt(3);
            var f = automataData.ElementAt(4).Split(',');

            automata.States = states.Select(StringFormat).ToList();
            automata.Alphabet = alphabet.Select(StringFormat).ToList();
            automata.Q0 = q0.StringFormat();
            automata.F = f.Select(StringFormat).ToList();

            var transitions = automataData.Skip(5);
            foreach (var transition in transitions)
            {
                if (transition.Contains("####"))
                    break;
                else
                    automata.AddTransition(new Transition().Parse(transition));
            }

            return automata;
        }

        public static string StringFormat(this String str)
        {
            return str.Trim()
                        .Replace("(", "")
                        .Replace(")", "");
        }
    }
}