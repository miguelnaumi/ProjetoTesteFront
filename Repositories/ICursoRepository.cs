using TesteProjetoFront.Models;

namespace TesteProjetoFront.Repositories
{
    public interface ICursoRepository
    {
        Task Add(Curso curso);
        Task Delete(int id);
        Task<IEnumerable<Curso>> GetAll();
        Task<Curso> GetById(int id);
        Task Update(Curso curso);
    }
}