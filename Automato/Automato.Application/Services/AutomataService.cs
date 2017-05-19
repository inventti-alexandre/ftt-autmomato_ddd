using Automato.App.Domain.Entities;
using Automato.App.Domain.Validation;
using Automato.App.Infra.Repositories;

namespace Automato.App.Services
{
    public class AutomataService
    {
        private readonly AutomataRepository AutomataRepository;
        public AutomataService()
        {
            AutomataRepository = new AutomataRepository();
        }

        public Automata GetFromFile(string fileName)
        {
            var automata = AutomataRepository.GetFromFile(fileName);
            this.RegisterAutomataScopeValidate(automata);
            return automata;
        }
    }
}