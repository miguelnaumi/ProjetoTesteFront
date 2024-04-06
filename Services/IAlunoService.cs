using Microsoft.AspNetCore.Mvc.Rendering;
using TesteProjetoFront.Models;

namespace TesteProjetoFront.Services
{
    public interface IAlunoService
    {
        Task<IEnumerable<Aluno>> GetAllAlunos();
        Task<Aluno> GetAlunoById(int id);
        Task AddAluno(Aluno aluno);
        Task UpdateAluno(Aluno aluno);
        Task DeleteAluno(int id);
        List<SelectListItem> GetAlunosAsSelectListItems();
        Task<IEnumerable<Aluno>> GetAlunosByIdTurma(int idTurma);
    }
}
