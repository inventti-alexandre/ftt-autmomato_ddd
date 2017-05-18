using Automato.Domain.Entities;
using Automato.Infra.Data.Utils;

namespace Automato.Infra.Data.Repositories
{
    public class AutomataRepository : BaseRepository
    {
        public Automata GetAutomataFromFile(string fileName)
        {
            return AutomataParser.FromTextLines(ReadFile(fileName));
        }
    }
}