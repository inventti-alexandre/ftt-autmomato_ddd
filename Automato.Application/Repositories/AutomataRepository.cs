using Automato.Application.Entities;
using Automato.Application.Extensions;
using Automato.Application.Interfaces;

namespace Automato.Application.Repositories
{
    public class AutomataRepository : BaseRepository, IAutomataRepository
    {
        public Automata GetAutomataFromFile(string fileName)
        {
            var automataData = ReadFile(fileName);
            return this.Parse(automataData);
        }
    }
}