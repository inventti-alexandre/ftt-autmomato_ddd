using Automato.App.Domain.Entities;
using Automato.App.Infra.Repositories;

namespace Automato.App.Services
{
    public class ResultService
    {
        private readonly ResultRepository ResultRepository;
        public ResultService()
        {
            ResultRepository = new ResultRepository();
        }

        public void ExportToFile(Result result, string fileName)
        {
            ResultRepository.ExportToFile(result, fileName);
        }
    }
}