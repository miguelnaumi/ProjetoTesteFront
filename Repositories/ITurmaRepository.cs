using TesteProjetoFront.Models;

namespace TesteProjetoFront.Repositories
{
    public interface ITurmaRepository
    {
        Task Add(Turma turma);
        Task Delete(int id);
        Task<IEnumerable<Turma>> GetAll();
        Task<Turma> GetById(int id);
        Task Update(Turma turma);
    }
}