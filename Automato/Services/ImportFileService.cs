using System.Collections.Generic;
using System.IO;

namespace Automato.Services
{
    public abstract class ImportFileService
    {
        public virtual List<string> ReadFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException();
            else
            
        }
    }
}