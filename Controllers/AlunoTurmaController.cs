using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TesteProjetoFront.Models;
using TesteProjetoFront.Repositories;
using TesteProjetoFront.Services;

namespace TesteProjetoFront.Controllers
{
    public class AlunoTurmaController : Controller
    {
        private readonly IAlunoTurmaService _alunoTurmaService;

        public AlunoTurmaController(IAlunoTurmaService alunoturmaService)
        {
            _alunoTurmaService = alunoturmaService;
        }

        public async Task<IActionResult> IndexAlunoTurma()
        {
            var turmas = await _alunoTurmaService.GetAll();
            return View(turmas);
        }

        public IActionResult CreateAlunoTurma()
        {
            AlunoTurma alunoTurma = new AlunoTurma();
            return View(alunoTurma);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAlunoTurma(AlunoTurma alunoTurma)
        {
            await _alunoTurmaService.AddAlunoTurma(alunoTurma);
            return RedirectToAction("GetAlunosByTurma", "Aluno",new { Id = alunoTurma.IdTurma });
        }

        public async Task<IActionResult> EditAlunoTurma(int idTurma, int idAluno)
        {
            var turma = await _alunoTurmaService.GetAlunoTurmaById(idTurma, idAluno);
            if (turma == null)
            {
                return NotFound();
            }
            return View(turma);
        }

        [HttpPost]
        public async Task<IActionResult> EditAlunoTurma(AlunoTurma turma)
        {
            await _alunoTurmaService.UpdateAlunoTurma(turma);
            return RedirectToAction("IndexTurma");
        }

        public async Task<IActionResult> DeleteAlunoTurma(int idTurma, int idAluno)
        {
            var turma = await _alunoTurmaService.GetAlunoTurmaById(idTurma, idAluno);
            if (turma == null)
            {
                return NotFound();
            }
            return View(turma);
        }

        [HttpPost, ActionName("DeleteAlunoTurma")]
        public async Task<IActionResult> DeleteConfirmed(int idTurma, int idAluno)
        {
            await _alunoTurmaService.DeleteAlunoTurma(idTurma, idAluno);
            return RedirectToAction("GetAlunosByTurma", "Aluno", new { Id = idTurma });
        }

        public Task<IEnumerable<Aluno>> GetAlunosDisponiveis(int idTurma = 0)
        {
            var alunos = _alunoTurmaService.GetAlunosDisponiveis(idTurma);
            return alunos;
        }

        public Task<IEnumerable<Turma>> GetTurmasDisponiveis(int idAluno = 0)
        {
            var turmas = _alunoTurmaService.GetTurmasDisponiveis(idAluno);
            return turmas;
        }
    }
}
