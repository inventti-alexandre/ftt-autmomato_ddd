using Automato.App.Domain.Interfaces;

namespace Automato.App.Domain.Validation
{
    public static class BaseRepositoryScope
    {
        public static void LoadFileScopeValidate(this IBaseRepository<string> BaseRepository, string fileName)
        {
            AssertionConcern.FileExists(fileName, "O arquivo informado não existe ou está inácessível.");
            AssertionConcern.FileIsEmpty(fileName, "O arquivo informado está vazio.");
        }
    }
}