using Automato.App.Domain.Entities;
using Automato.App.Domain.Validation;

namespace Automato.App.Domain.Extensions
{
    public static class TransitionExtension
    {
        public static Transition Parse(this Transition transition, string str)
        {
            var data = str.Split(',');
            transition.ParseTransitionDataScopeValidate(data);

            transition.StartState = data[0].StringFormat(); ;
            transition.Symbol = data[1].StringFormat();
            transition.EndState = data[2].StringFormat();

            return transition;
        }
    }
}