using Automato.App.Domain.Entities;
using Automato.App.Domain.Extensions;
using Automato.App.Domain.Interfaces;
using System.Collections.Generic;

namespace Automato.App.Infra.Repositories
{
    public class AutomataRepository : BaseRepository, IAutomataRepository
    {
        public List<string> FileLines { get; set; }
        public Automata GetFromFile(string fileName)
        {
            var automata = new Automata().Parse(ReadFile(fileName));
            return automata;
        }
    }
}