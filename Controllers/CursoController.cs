using Microsoft.AspNetCore.Mvc;
using TesteProjetoFront.Models;
using TesteProjetoFront.Repositories;
using TesteProjetoFront.Services;

namespace TesteProjetoFront.Controllers
{
    public class CursoController : Controller
    {
        private readonly ICursoService _cursoService;

        public CursoController(ICursoService cursoService)
        {
            _cursoService = cursoService;
        }

        public async Task<IActionResult> IndexCurso()
        {
            var cursos = await _cursoService.GetAllCursos();
            return View(cursos);
        }

        public IActionResult CreateCurso()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCurso(Curso curso)
        {
            try
            {
                await _cursoService.AddCurso(curso);
                return RedirectToAction("IndexCurso");
            }
            catch(Exception ex)
            {
                return StatusCode(Response.StatusCode, ex.Message);
            }
        }

        public async Task<IActionResult> EditCurso(int id)
        {
            try
            {
                var curso = await _cursoService.GetCursoById(id);
                if (curso == null)
                {
                    return NotFound();
                }
                return View(curso);
            }
            catch(Exception ex) 
            {
                return StatusCode(Response.StatusCode, ex.Message);
            }

        }

        [HttpPost]
        public async Task<IActionResult> EditCurso(Curso curso)
        {
            try
            {
                await _cursoService.UpdateCurso(curso);
                return RedirectToAction("IndexCurso");
            }
            catch(Exception ex)
            {
                return StatusCode(Response.StatusCode, ex.Message);
            }
        }

        public async Task<IActionResult> DeleteCurso(int id)
        {
            try
            {
                var curso = await _cursoService.GetCursoById(id);
                if (curso == null)
                {
                    return NotFound();
                }
                return View(curso);
            }
            catch (Exception ex)
            {
                return StatusCode(Response.StatusCode, ex.Message);
            }

        }

        [HttpPost, ActionName("DeleteCurso")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _cursoService.DeleteCurso(id);
                return RedirectToAction("IndexCurso");
            }
            catch(Exception ex)
            {
                return StatusCode(Response.StatusCode , ex.Message);
            }

        }
    }
}
