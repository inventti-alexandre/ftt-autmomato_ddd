using System.Collections.Generic;
using System.IO;
using System.Linq;
using Automato.App.Domain.Interfaces;
using Automato.App.Domain.Validation;

namespace Automato.App.Infra.Repositories
{
    public abstract class BaseRepository : IBaseRepository<string>
    {
        public virtual List<string> ReadFile(string fileName)
        {
            this.LoadFileScopeValidate(fileName);
            return File.ReadAllLines(fileName).ToList();
        }
    }
}