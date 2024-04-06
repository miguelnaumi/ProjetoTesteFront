using Microsoft.AspNetCore.Mvc.Rendering;
using TesteProjetoFront.Models;
using TesteProjetoFront.Repositories;
using System.Linq;

namespace TesteProjetoFront.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public async Task<IEnumerable<Aluno>> GetAllAlunos()
        {
            return await _alunoRepository.GetAll();
        }

        public async Task<Aluno> GetAlunoById(int id)
        {
            return await _alunoRepository.GetById(id);
        }

        public async Task AddAluno(Aluno aluno)
        {
            await _alunoRepository.Add(aluno);
        }

        public async Task UpdateAluno(Aluno aluno)
        {
            await _alunoRepository.Update(aluno);
        }

        public async Task DeleteAluno(int id)
        {
            await _alunoRepository.Delete(id);
        }

        public List<SelectListItem> GetAlunosAsSelectListItems()
        {
            var alunos = _alunoRepository.GetAll();
            var alunosAsSelectListItems = alunos.Result.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Nome
            }).ToList();

            return alunosAsSelectListItems;
        }
        public async Task<IEnumerable<Aluno>> GetAlunosByIdTurma(int idTurma)
        {
            return await _alunoRepository.GetAlunosByIdTurma(idTurma);
        }
    }
}
