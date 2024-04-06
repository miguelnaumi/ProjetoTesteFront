using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using RestSharp;
using TesteProjetoFront.Models;

namespace TesteProjetoFront.Repositories
{
    public class AlunoTurmaRepository : IAlunoTurmaRepository
    {
        private readonly RestClient _restClient;

        public AlunoTurmaRepository(IOptions<ApiSettings> apiSettings)
        {
            _restClient = new RestClient(apiSettings.Value.BaseUrl);
        }

        public async Task<IEnumerable<AlunoTurma>> GetAll()
        {
            var request = new RestRequest("api/alunoturma", RestSharp.Method.Get);
            var response = await _restClient.ExecuteAsync<ResponseMicroService<IEnumerable<AlunoTurma>>>(request);
            if (!response.IsSuccessful)
            {
                throw new Exception($"Falha ao consultar as alunoturmas: {response.Data?.Message ?? response.ErrorMessage}");
            }

            return response.Data.Result;
        }

        public async Task<AlunoTurma> GetById(int idTurma, int idAluno)
        {
            var request = new RestRequest($"api/alunoturma/{idTurma}/{idAluno}", RestSharp.Method.Get);
            var response = await _restClient.ExecuteAsync<ResponseMicroService<AlunoTurma>>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Falha ao consultar a alunoturma idTurma {idTurma}: {response.Data?.Message ?? response.ErrorMessage}");
            }

            return response.Data.Result;
        }

        public async Task Add(AlunoTurma alunoturma)
        {
            var request = new RestRequest("api/alunoturma", RestSharp.Method.Post);
            request.AddJsonBody(alunoturma);

            var response = await _restClient.ExecuteAsync<ResponseMicroService<bool>>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Falha ao adicionar a aluno a turma: {response.Data?.Message ?? response.ErrorMessage}");
            }
        }

        public async Task Update(AlunoTurma alunoturma)
        {
            var request = new RestRequest($"api/alunoturma/{alunoturma.IdTurmaOld}/{alunoturma.IdAlunoOld}", RestSharp.Method.Put);
            request.AddJsonBody(alunoturma);

            var response = await _restClient.ExecuteAsync<ResponseMicroService<bool>>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Falha ao editar a alunoturma idTurma {alunoturma.IdTurmaOld}: {response.Data?.Message ?? response.ErrorMessage}");
            }
        }

        public async Task Delete(int idTurma, int idAluno)
        {
            var request = new RestRequest($"api/alunoturma/{idTurma}/{idAluno}", RestSharp.Method.Delete);
            var response = await _restClient.ExecuteAsync<ResponseMicroService<bool>>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Falha ao deletar a alunoturma idTurma {idTurma}: {response.Data?.Message ?? response.ErrorMessage}");
            }
        }

        public async Task<IEnumerable<Aluno>> GetAlunosDisponiveis(int idTurma)
        {
            var request = new RestRequest($"api/alunoturma/alunos/{idTurma}", RestSharp.Method.Get);
            var response = await _restClient.ExecuteAsync<ResponseMicroService<IEnumerable<Aluno>>>(request);
            if (!response.IsSuccessful)
            {
                throw new Exception($"Falha ao consultar os alunos disponíveis: {response.Data?.Message ?? response.ErrorMessage}");
            }

            return response.Data.Result;
        }
        public async Task<IEnumerable<Turma>> GetTurmasDisponiveis(int idAluno)
        {
            var request = new RestRequest($"api/alunoturma/turmas/{idAluno}", RestSharp.Method.Get);
            var response = await _restClient.ExecuteAsync<ResponseMicroService<IEnumerable<Turma>>>(request);
            if (!response.IsSuccessful)
            {
                throw new Exception($"Falha ao consultar as Turmas disponíveis: {response.Data?.Message ?? response.ErrorMessage}");
            }

            return response.Data.Result;
        }
    }
}
