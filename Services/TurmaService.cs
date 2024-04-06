using Microsoft.AspNetCore.Mvc.Rendering;
using TesteProjetoFront.Models;
using TesteProjetoFront.Repositories;

namespace TesteProjetoFront.Services
{
    public class TurmaService : ITurmaService
    {
        private readonly ITurmaRepository _turmaRepository;
        private readonly ICursoRepository _cursoRepository;

        public TurmaService(ITurmaRepository turmaRepository, ICursoRepository cursoRepository)
        {
            _turmaRepository = turmaRepository;
            _cursoRepository = cursoRepository;
        }

        public async Task<IEnumerable<Turma>> GetAll()
        {
            return await _turmaRepository.GetAll();
        }

        public async Task<Turma> GetTurmaById(int id)
        {
            return await _turmaRepository.GetById(id);
        }

        public async Task AddTurma(Turma turma)
        {
            await _turmaRepository.Add(turma);
        }

        public async Task UpdateTurma(Turma turma)
        {
            await _turmaRepository.Update(turma);
        }

        public async Task DeleteTurma(int id)
        {
            await _turmaRepository.Delete(id);
        }

        public List<SelectListItem> GetTurmasAsSelectListItems()
        {
            var alunos = _turmaRepository.GetAll();
            var alunosAsSelectListItems = alunos.Result.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Nome
            }).ToList();

            return alunosAsSelectListItems;
        }

        public List<SelectListItem> GetCursosAsSelectListItems()
        {
            var cursos = _cursoRepository.GetAll();
            var cursosAsSelectListItems = cursos.Result.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Nome
            }).ToList();

            return cursosAsSelectListItems;
        }
    }
}
