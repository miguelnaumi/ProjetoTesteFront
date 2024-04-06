using TesteProjetoFront.Models;

namespace TesteProjetoFront.Repositories
{
    public interface IAlunoTurmaRepository
    {
        Task Add(AlunoTurma alunoturma);
        Task Delete(int idTurma, int idAluno);
        Task<IEnumerable<AlunoTurma>> GetAll();
        Task<IEnumerable<Aluno>> GetAlunosDisponiveis(int idTurma);
        Task<AlunoTurma> GetById(int idTurma, int idAluno);
        Task<IEnumerable<Turma>> GetTurmasDisponiveis(int idAluno);
        Task Update(AlunoTurma alunoturma);
    }
}