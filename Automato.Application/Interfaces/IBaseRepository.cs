using System.Collections.Generic;

namespace Automato.Application.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> ReadFile(string fileName);
    }
}