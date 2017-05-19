using Automato.App.Entities;
using Automato.App.Extensions;
using Automato.App.Interfaces;
using Automato.App.Validation;
using System.Collections.Generic;

namespace Automato.App.Repositories
{
    public class AutomataRepository : BaseRepository, IAutomataRepository
    {
        public List<string> FileLines { get; set; }
        public Automata GetAutomataFromFile(string fileName)
        {
            var automata = new Automata().Parse(ReadFile(fileName));
            automata.RegisterAutomataScopeValidate();
            return automata;
        }
    }
}