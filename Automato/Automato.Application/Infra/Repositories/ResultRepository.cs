using Automato.App.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Automato.App.Infra.Repositories
{
    public class ResultRepository : BaseRepository
    {
        public override List<string> ReadFile(string fileName)
        {
            throw new NotImplementedException("O arquivo de saída não pode ser importado!");
        }

        public void ExportToFile(Result result, string fileName)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName))
                {
                    foreach (string line in result.Lines)
                    {
                        file.WriteLine(line);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro ao exportar o arquivo.");
            }

        }
    }
}