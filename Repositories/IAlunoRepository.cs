using TesteProjetoFront.Models;

namespace TesteProjetoFront.Repositories
{
    public interface IAlunoRepository
    {
        Task Add(Aluno aluno);
        Task Delete(int id);
        Task<IEnumerable<Aluno>> GetAll();
        Task<IEnumerable<Aluno>> GetAlunosByIdTurma(int idTurma);
        Task<Aluno> GetById(int id);
        Task Update(Aluno aluno);
    }
}