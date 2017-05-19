using Automato.App.Domain.Entities;

namespace Automato.App.Domain.Interfaces
{
    public interface IAutomataRepository : IBaseRepository<string>
    {
        Automata GetFromFile(string fileName);
    }
}