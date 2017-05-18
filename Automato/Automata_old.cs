using Automato.Validation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Automato
{
    public class Automata_old
    {
        #region Atributes/Fields
        private String _q0;
        private List<String> _states;
        private List<String> _f;
        private List<String> _alphabet;
        private List<Transition> Transitions = new List<Transition>();
        private string message = "";
        #endregion

        #region Properties
        public String Q0
        {
            get
            {
                return _q0;
            }
            private set
            {
                value.IsValidState(States, "O estado incial informado não é válido.");
                _q0 = value;
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
                value.MinLength(1, "Você deve informar no mínimo um estado para o automato.");
                _states = value;
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
                value.MinLength(1, "O alfabeto informado deve conter no mínimo um símbolo.");
                _alphabet = value;
            }
        }

        public List<String> F {
            get {
                return _f ?? new List<String>();
            }
            private set {
                value.MinLength(1, "Você precisa informa no mínimo um estado final para o automato.");
                _f = value;
            }
        }
        #endregion

        #region Constructors
        public Automata_old(IEnumerable<String> states,
                        IEnumerable<String> alphabet,
                        String q0,
                        IEnumerable<String> f)
        {
            States = states.Select(s => s.Format()).ToList();
            Alphabet = alphabet.Select(s => s.Format()).ToList();
            Q0 = q0.Trim();
            F = f.Select(s => s.Format()).ToList();
        }
        #endregion

        #region Methods
        public void AddTransition(IEnumerable<String> data)
        {
            data.LengthIsEqual(3, "O número de argumentos informado para a função de transição não é válido.");
            Transition t = new Transition(data.ElementAt(0), data.ElementAt(1), data.ElementAt(2));
            t.Validate(States, Alphabet);
            Transitions.Add(t);
        }

        public string Accepts(string input)
        {
            message += "Trying to accept: " + input;

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