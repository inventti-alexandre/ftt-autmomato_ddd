using Automato.Domain.Entities;
using System.Collections.Generic;

namespace Automato.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> ReadFile(string fileName);
    }
}