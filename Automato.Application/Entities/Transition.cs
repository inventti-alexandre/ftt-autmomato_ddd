namespace Automato.Application.Entities
{
    public class Transition
    {
        #region Atributes/Fields

        #endregion

        #region Properties
        public string StartState { get; private set; }
        public string EndState { get; private set; }
        public string Symbol { get; private set; }
        #endregion

        #region Constructors
        public Transition(string startState, string symbol, string endState)
        {
            StartState = startState;
            Symbol = symbol;
            EndState = endState;
        }
        #endregion

        #region Methods
        #endregion
    }
}