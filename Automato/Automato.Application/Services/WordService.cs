using Automato.App.Infra.Repositories;
using System.Collections.Generic;

namespace Automato.App.Domain.Services
{
    public class WordService
    {
        private readonly WordRepository WordRepository;
        public WordService()
        {
            WordRepository = new WordRepository();
        }

        public List<string> GetFromFile(string fileName)
        {
            return WordRepository.GeFromFile(fileName);
        }
    }
}