using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using Microsoft.Extensions.Options;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteProjetoFront.Models;

namespace TesteProjetoFront.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        private readonly RestClient _restClient;

        public CursoRepository(IOptions<ApiSettings> apiSettings)
        {
            _restClient = new RestClient(apiSettings.Value.BaseUrl);
        }

        public async Task<IEnumerable<Curso>> GetAll()
        {
            var request = new RestRequest("api/curso", RestSharp.Method.Get);
            var response = await _restClient.ExecuteAsync<ResponseMicroService<IEnumerable<Curso>>>(request);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Falha ao consultar os cursos: {response.Data?.Message ?? response.ErrorMessage}");
            }

            return response.Data.Result;
        }

        public async Task<Curso> GetById(int id)
        {
            var request = new RestRequest($"api/curso/{id}", RestSharp.Method.Get);
            var response = await _restClient.ExecuteAsync< ResponseMicroService<Curso>>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Falha ao consultar o curso id {id}: {response.Data?.Message ?? response.ErrorMessage}");
            }

            return response.Data.Result;
        }

        public async Task Add(Curso curso)
        {
            var request = new RestRequest("api/curso", RestSharp.Method.Post);
            request.AddJsonBody(curso);

            var response = await _restClient.ExecuteAsync<ResponseMicroService<bool>>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Falha ao adicionar o curso: {response.Data?.Message ?? response.ErrorMessage}");
            }
        }

        public async Task Update(Curso curso)
        {
            var request = new RestRequest($"api/curso/{curso.Id}", RestSharp.Method.Put);
            request.AddJsonBody(curso);

            var response = await _restClient.ExecuteAsync<ResponseMicroService<bool>>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Falha ao editar o curso id {curso.Id}: {response.Data?.Message ?? response.ErrorMessage}");
            }
        }

        public async Task Delete(int id)
        {
            var request = new RestRequest($"api/curso/{id}", RestSharp.Method.Delete);
            var response = await _restClient.ExecuteAsync<ResponseMicroService<bool>>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Falha ao deletar o curso id {id}: {response.Data?.Message ?? response.ErrorMessage}");
            }
        }
    }
}
