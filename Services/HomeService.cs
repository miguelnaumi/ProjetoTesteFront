using Microsoft.AspNetCore.Mvc.Rendering;
using TesteProjetoFront.Models;
using TesteProjetoFront.Repositories;
using System.Linq;
using Microsoft.CodeAnalysis.Scripting;

namespace TesteProjetoFront.Services
{
    public class HomeService : IHomeService
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly ITurmaRepository _turmaRepository;
        private readonly ICursoRepository _cursoRepository;

        public HomeService(IAlunoRepository alunoRepository, ITurmaRepository turmaRepository, ICursoRepository cursoRepository)
        {
            _alunoRepository = alunoRepository;
            _turmaRepository = turmaRepository;
            _cursoRepository = cursoRepository;
        }

        public async Task<HomeModel> GetHomeInfo()
        {
            var homeModel = new HomeModel();
            homeModel.NumAlunos = (await _alunoRepository.GetAll()).Count();
            homeModel.NumTurmas = (await _turmaRepository.GetAll()).Count();
            homeModel.NumCursos = (await _cursoRepository.GetAll()).Count();
            return homeModel;
        }
    }
}
