using Automato.Application.Entities;
using Automato.Application.Extensions;
using Automato.Application.Interfaces;
using System.Collections.Generic;

namespace Automato.Application.Repositories
{
    public class AutomataRepository : BaseRepository, IAutomataRepository
    {
        public List<string> FileLines { get; set; }
        public Automata GetAutomataFromFile(string fileName)
        {
            return new Automata().Parse(ReadFile(fileName));
        }
    }
}