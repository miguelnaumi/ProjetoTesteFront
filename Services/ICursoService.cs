using TesteProjetoFront.Models;

namespace TesteProjetoFront.Services
{
    public interface ICursoService
    {
        Task<IEnumerable<Curso>> GetAllCursos();
        Task<Curso> GetCursoById(int id);
        Task AddCurso(Curso curso);
        Task UpdateCurso(Curso curso);
        Task DeleteCurso(int id);
    }
}
