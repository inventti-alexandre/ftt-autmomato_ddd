using Automato.Application.Validation;
using System;
using System.Collections.Generic;

namespace Automato.Application.Entities
{
    public class Automata
    {
        #region Properties
        public string Q0 { get; set; }
        public List<String> States { get; set; }
        public List<String> Alphabet { get; set; }
        public List<String> F { get; set; }
        public List<Transition> Transitions = new List<Transition>();
        #endregion

        #region Constructors
        #endregion

        #region Methods
        public void AddTransition(Transition transition)
        {
            transition.RegisterTransitionDataScopeValidate(States, Alphabet);
            Transitions.Add(transition);
        }

        public string Accepts(string input)
        {
            if (Accepts(Q0, input))
                return "ACEITO";
            else
                return "NÃO ACEITO";
        }

        private bool Accepts(string currentState, string input)
        {
            if (input.Length > 0)
            {
                var transitions = GetAllTransitions(currentState, input[0].ToString());
                foreach (var transition in transitions)
                {
                    if (Accepts(transition.EndState, input.Substring(1)))
                    {
                        return true;
                    }
                }
                return false;
            }
            if (F.Contains(currentState))
            {
                return true;
            }
            return false;
        }

        private IEnumerable<Transition> GetAllTransitions(string currentState, string symbol)
        {
            return Transitions.FindAll(t => t.StartState == currentState && t.Symbol == symbol);
        }
        #endregion
    }
}