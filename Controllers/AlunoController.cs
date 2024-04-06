using Microsoft.AspNetCore.Mvc;
using TesteProjetoFront.Models;
using TesteProjetoFront.Repositories;
using TesteProjetoFront.Services;

namespace TesteProjetoFront.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        public async Task<IActionResult> IndexAluno()
        {
            var alunos = await _alunoService.GetAllAlunos();
            return View(alunos);
        }

        public IActionResult CreateAluno()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAluno(Aluno aluno)
        {
            await _alunoService.AddAluno(aluno);
            return RedirectToAction("IndexAluno");
        }

        public async Task<IActionResult> EditAluno(int id)
        {
            var aluno = await _alunoService.GetAlunoById(id);
            if (aluno == null)
            {
                return NotFound();
            }
            return View(aluno);
        }

        [HttpPost]
        public async Task<IActionResult> EditAluno(Aluno aluno)
        {
            await _alunoService.UpdateAluno(aluno);
            return RedirectToAction("IndexAluno");
        }

        public async Task<IActionResult> DeleteAluno(int id)
        {
            var aluno = await _alunoService.GetAlunoById(id);
            if (aluno == null)
            {
                return NotFound();
            }
            return View(aluno);
        }

        [HttpPost, ActionName("DeleteAluno")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _alunoService.DeleteAluno(id);
            return RedirectToAction("IndexAluno");
        }

        public async Task<IActionResult> GetAlunosByTurma(int id)
        {
            var alunos = await _alunoService.GetAlunosByIdTurma(id);
            var turma = alunos.FirstOrDefault()?.Turma;
            if(turma == null)
            {
                return RedirectToAction("IndexTurma", "Turma");
            }
            ViewData["Turma"] = turma;
            return View("AlunoPorTurma", alunos);
        }
    }
}
