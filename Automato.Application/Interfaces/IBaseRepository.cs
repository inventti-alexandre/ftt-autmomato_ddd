using System.Collections.Generic;

namespace Automato.Application.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> ReadFile(string fileName);
    }
}