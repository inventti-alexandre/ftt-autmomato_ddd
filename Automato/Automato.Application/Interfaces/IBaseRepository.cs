using System.Collections.Generic;

namespace Automato.App.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> ReadFile(string fileName);
    }
}