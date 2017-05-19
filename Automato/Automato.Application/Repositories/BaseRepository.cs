using System.Collections.Generic;
using System.IO;
using System.Linq;
using Automato.Application.Interfaces;

namespace Automato.Application.Repositories
{
    public abstract class BaseRepository : IBaseRepository<string>
    {
        public virtual List<string> ReadFile(string fileName)
        {
            if (File.Exists(fileName))
                return File.ReadAllLines(fileName).ToList();
            else
                throw new FileNotFoundException(string.Format("Arquivo {0} não encontrado.", fileName));
        }
    }
}