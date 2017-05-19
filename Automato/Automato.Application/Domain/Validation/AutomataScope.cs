using Automato.App.Domain.Entities;
using Automato.App.Infra.Repositories;
using System.Collections.Generic;

namespace Automato.App.Domain.Validation
{
    public static class AutomataScope
    {
        public static void ParseAutomataDataScopeValidate(this Automata automata, IEnumerable<string> lines)
        {
            AssertionConcern.CollectionLengthBiggerThan(lines, 6, "O automato está incompleto.");
        }
    }
}