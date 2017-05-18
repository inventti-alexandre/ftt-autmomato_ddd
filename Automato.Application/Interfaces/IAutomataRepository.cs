using Automato.Application.Entities;

namespace Automato.Application.Interfaces
{
    public interface IAutomataRepository : IBaseRepository<string>
    {
        Automata GetAutomataFromFile(string fileName);
    }
}