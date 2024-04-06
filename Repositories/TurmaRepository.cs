using Microsoft.Extensions.Options;
using RestSharp;
using TesteProjetoFront.Models;

namespace TesteProjetoFront.Repositories
{
    public class TurmaRepository : ITurmaRepository
    {
        private readonly RestClient _restClient;

        public TurmaRepository(IOptions<ApiSettings> apiSettings)
        {
            _restClient = new RestClient(apiSettings.Value.BaseUrl);
        }

        public async Task<IEnumerable<Turma>> GetAll()
        {
            var request = new RestRequest("api/turma", RestSharp.Method.Get);
            var response = await _restClient.ExecuteAsync<ResponseMicroService<IEnumerable<Turma>>>(request);
            if (!response.IsSuccessful)
            {
                throw new Exception($"Falha ao consultar as turmas: {response.Data?.Message ?? response.ErrorMessage}");
            }

            return response.Data.Result;
        }

        public async Task<Turma> GetById(int id)
        {
            var request = new RestRequest($"api/turma/{id}", RestSharp.Method.Get);
            var response = await _restClient.ExecuteAsync<ResponseMicroService<Turma>>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Falha ao consultar a turma id {id}: {response.Data?.Message ?? response.ErrorMessage}");
            }

            return response.Data.Result;
        }

        public async Task Add(Turma turma)
        {
            var request = new RestRequest("api/turma", RestSharp.Method.Post);
            request.AddJsonBody(turma);

            var response = await _restClient.ExecuteAsync<ResponseMicroService<bool>>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Falha ao adicionar a turma: {response.Data?.Message ?? response.ErrorMessage}");
            }
        }

        public async Task Update(Turma turma)
        {
            var request = new RestRequest($"api/turma/{turma.Id}", RestSharp.Method.Put);
            request.AddJsonBody(turma);

            var response = await _restClient.ExecuteAsync<ResponseMicroService<bool>>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Falha ao editar a turma id {turma.Id}: {response.Data?.Message ?? response.ErrorMessage}");
            }
        }

        public async Task Delete(int id)
        {
            var request = new RestRequest($"api/turma/{id}", RestSharp.Method.Delete);
            var response = await _restClient.ExecuteAsync<ResponseMicroService<bool>>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Falha ao deletar a turma id {id}: {response.Data?.Message ?? response.ErrorMessage}");
            }
        }
    }
}
