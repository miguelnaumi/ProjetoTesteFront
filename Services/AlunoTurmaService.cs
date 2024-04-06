using Microsoft.AspNetCore.Mvc.Rendering;
using TesteProjetoFront.Models;
using TesteProjetoFront.Repositories;

namespace TesteProjetoFront.Services
{
    public class AlunoTurmaService : IAlunoTurmaService
    {
        private readonly IAlunoTurmaRepository _alunoturmaRepository;

        public AlunoTurmaService(IAlunoTurmaRepository alunoturmaRepository, ICursoRepository cursoRepository)
        {
            _alunoturmaRepository = alunoturmaRepository;
        }

        public async Task<IEnumerable<AlunoTurma>> GetAll()
        {
            return await _alunoturmaRepository.GetAll();
        }

        public async Task<AlunoTurma> GetAlunoTurmaById(int idTurma, int idAluno)
        {
            return await _alunoturmaRepository.GetById(idTurma, idAluno);
        }

        public async Task AddAlunoTurma(AlunoTurma alunoturma)
        {
            await _alunoturmaRepository.Add(alunoturma);
        }

        public async Task UpdateAlunoTurma(AlunoTurma alunoturma)
        {
            await _alunoturmaRepository.Update(alunoturma);
        }

        public async Task DeleteAlunoTurma(int idTurma, int idAluno)
        {
            await _alunoturmaRepository.Delete(idTurma, idAluno);
        }

        public async Task<IEnumerable<Turma>> GetTurmasDisponiveis(int idTurma)
        {
            var turmas = await _alunoturmaRepository.GetTurmasDisponiveis(idTurma);
            return turmas;
        }

        public async Task<IEnumerable<Aluno>> GetAlunosDisponiveis(int idAluno)
        {
            var alunos = await _alunoturmaRepository.GetAlunosDisponiveis(idAluno);
            return alunos;
        }
    }
}
