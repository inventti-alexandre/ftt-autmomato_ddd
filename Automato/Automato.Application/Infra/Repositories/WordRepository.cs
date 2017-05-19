using System.Collections.Generic;

namespace Automato.App.Infra.Repositories
{
    public class WordRepository : BaseRepository
    {
        public List<string> GeFromFile(string fileName)
        {
            return ReadFile(fileName);
        }
    }
}