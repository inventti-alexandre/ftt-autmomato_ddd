using Automato.App.Entities;

namespace Automato.App.Interfaces
{
    public interface IAutomataRepository : IBaseRepository<string>
    {
        Automata GetAutomataFromFile(string fileName);
    }
}