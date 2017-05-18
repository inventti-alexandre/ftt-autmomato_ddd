using System.Collections.Generic;
using System.IO;
using System.Linq;
using Automato.Application.Interfaces;

namespace Automato.Application.Repositories
{
    public abstract class BaseRepository : IBaseRepository<string>
    {
        public virtual IEnumerable<string> ReadFile(string fileName)
        {
            List<string> lines;

            if (File.Exists(fileName))
                lines = File.ReadAllLines(fileName).ToList();
            else
                throw new FileNotFoundException(string.Format("Arquivo {0} não encontrado.", fileName));

            if (lines.Any())
                return lines;
            throw new FileNotFoundException(string.Format("O arquivo {0} está vazio.", fileName));
        }
    }
}