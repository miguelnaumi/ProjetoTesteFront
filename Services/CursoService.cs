using TesteProjetoFront.Models;
using TesteProjetoFront.Repositories;

namespace TesteProjetoFront.Services
{
    public class CursoService : ICursoService
    {
        private readonly ICursoRepository _cursoRepository;

        public CursoService(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        public async Task<IEnumerable<Curso>> GetAllCursos()
        {
            return await _cursoRepository.GetAll();
        }

        public async Task<Curso> GetCursoById(int id)
        {
            return await _cursoRepository.GetById(id);
        }

        public async Task AddCurso(Curso curso)
        {
            await _cursoRepository.Add(curso);
        }

        public async Task UpdateCurso(Curso curso)
        {
            await _cursoRepository.Update(curso);
        }

        public async Task DeleteCurso(int id)
        {
            await _cursoRepository.Delete(id);
        }
    }
}
