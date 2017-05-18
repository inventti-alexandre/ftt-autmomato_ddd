using System;
using System.Collections.Generic;
using Automato.Domain.Interfaces;
using System.IO;
using System.Linq;

namespace Automato.Infra.Data.Repositories
{
    public abstract class BaseRepository : IBaseRepository<string>
    {
        public virtual IEnumerable<string> ReadFile(string fileName)
        {
            if (File.Exists(fileName))
                return File.ReadAllLines(fileName).ToList();
            throw new FileNotFoundException(String.Format("Arquivo {0} não encontrado.", fileName));
        }
    }
}