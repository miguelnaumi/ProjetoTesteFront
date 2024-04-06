using Microsoft.AspNetCore.Mvc.Rendering;
using TesteProjetoFront.Models;

namespace TesteProjetoFront.Services
{
    public interface IAlunoTurmaService
    {
        Task AddAlunoTurma(AlunoTurma alunoturma);
        Task DeleteAlunoTurma(int idTurma, int idAluno);
        Task<IEnumerable<AlunoTurma>> GetAll();
        Task<IEnumerable<Aluno>> GetAlunosDisponiveis(int idAluno);
        Task<AlunoTurma> GetAlunoTurmaById(int idTurma, int idAluno);
        Task<IEnumerable<Turma>> GetTurmasDisponiveis(int idTurma);
        Task UpdateAlunoTurma(AlunoTurma alunoturma);
    }
}