using Automato.Application.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Automato.Application.Entities
{
    public class Automata
    {
        #region Atributes/Fields
        private String _q0;
        private List<String> _states;
        private List<String> _f;
        private List<String> _alphabet;
        private List<Transition> Transitions = new List<Transition>();
        #endregion

        #region Properties

        public string Q0
        {
            get
            {
                return _q0;
            }
            set
            {
                _q0 = value;
                this.IsValidQ0State("O estado inicial informado para o automato não é válido.");
            }
        }

        public List<String> States
        {
            get
            {
                return _states ?? new List<String>();
            }
            private set
            {
                _states = value;
                this.IsValidStates("Você deve informar no mínimo um estado para o automato.");
            }
        }

        public List<String> Alphabet
        {
            get
            {
                return _alphabet ?? new List<String>();
            }
            private set
            {
                _alphabet = value;
                this.IsValidAlphabet("O alfabeto informado deve conter no mínimo um símbolo.");
            }
        }

        public List<String> F
        {
            get
            {
                return _f ?? new List<String>();
            }
            private set
            {
                _f = value;
                this.IsValidEndState("O conjunto de estados finais informado para o automato nõ é válido.");

            }
        }
        #endregion

        #region Constructors
        public Automata(IEnumerable<String> states,
                        IEnumerable<String> alphabet,
                        String q0,
                        IEnumerable<String> f)
        {
            States = states.Select(this.StateFormat).ToList();
            Alphabet = alphabet.Select(this.SymbolFormat).ToList();
            Q0 = this.StateFormat(q0);
            F = f.Select(this.StateFormat).ToList();
        }
        #endregion

        #region Methods
        public void AddTransition(Transition transition)
        {
            this.IsValidTransition(transition, "A função de transição informada não é válida.");
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