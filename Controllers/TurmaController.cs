using Microsoft.AspNetCore.Mvc;
using TesteProjetoFront.Models;
using TesteProjetoFront.Repositories;
using TesteProjetoFront.Services;

namespace TesteProjetoFront.Controllers
{
    public class TurmaController : Controller
    {
        private readonly ITurmaService _turmaService;

        public TurmaController(ITurmaService turmaService)
        {
            _turmaService = turmaService;
        }

        public async Task<IActionResult> IndexTurma()
        {
            var turmas = await _turmaService.GetAll();
            return View(turmas);
        }

        public IActionResult CreateTurma()
        {
            Turma turma = new Turma();
            var cursos = _turmaService.GetCursosAsSelectListItems();
            turma.Cursos = cursos;
            return View(turma);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTurma(Turma turma)
        {
            await _turmaService.AddTurma(turma);
            return RedirectToAction("IndexTurma");
        }

        public async Task<IActionResult> EditTurma(int id)
        {
            var turma = await _turmaService.GetTurmaById(id);
            if (turma == null)
            {
                return NotFound();
            }
            var cursos = _turmaService.GetCursosAsSelectListItems();
            turma.Cursos = cursos;
            return View(turma);
        }

        [HttpPost]
        public async Task<IActionResult> EditTurma(Turma turma)
        {
            await _turmaService.UpdateTurma(turma);
            return RedirectToAction("IndexTurma");
        }

        public async Task<IActionResult> DeleteTurma(int id)
        {
            var turma = await _turmaService.GetTurmaById(id);
            if (turma == null)
            {
                return NotFound();
            }
            return View(turma);
        }

        [HttpPost, ActionName("DeleteTurma")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _turmaService.DeleteTurma(id);
            return RedirectToAction("IndexTurma");
        }
    }
}
