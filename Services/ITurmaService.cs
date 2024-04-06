using Microsoft.AspNetCore.Mvc.Rendering;
using TesteProjetoFront.Models;

namespace TesteProjetoFront.Services
{
    public interface ITurmaService
    {
        Task AddTurma(Turma turma);
        Task DeleteTurma(int id);
        Task<IEnumerable<Turma>> GetAll();
        List<SelectListItem> GetTurmasAsSelectListItems();
        Task<Turma> GetTurmaById(int id);
        Task UpdateTurma(Turma turma);
        List<SelectListItem> GetCursosAsSelectListItems();
    }
}