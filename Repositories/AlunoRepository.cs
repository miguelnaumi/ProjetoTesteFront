using Microsoft.Extensions.Options;
using RestSharp;
using TesteProjetoFront.Models;
using TesteProjetoFront.Repositories;

public class AlunoRepository : IAlunoRepository
{
    private readonly RestClient _restClient;

    public AlunoRepository(IOptions<ApiSettings> apiSettings)
    {
        _restClient = new RestClient(apiSettings.Value.BaseUrl);
    }

    public async Task<IEnumerable<Aluno>> GetAll()
    {
        var request = new RestRequest("api/aluno", Method.Get);
        var response = await _restClient.ExecuteAsync<ResponseMicroService<IEnumerable<Aluno>>>(request);
        if (!response.IsSuccessful)
        {
            throw new Exception($"Falha ao consultar os alunos: {response.Data?.Message ?? response.ErrorMessage}");
        }

        return response.Data.Result;
    }

    public async Task<Aluno> GetById(int id)
    {
        var request = new RestRequest($"api/aluno/{id}", Method.Get);
        var response = await _restClient.ExecuteAsync<ResponseMicroService<Aluno>>(request);

        if (!response.IsSuccessful)
        {
            throw new Exception($"Falha ao consultar o aluno id {id}: {response.Data?.Message ?? response.ErrorMessage}");
        }

        return response.Data.Result;
    }

    public async Task Add(Aluno aluno)
    {
        var request = new RestRequest("api/aluno", Method.Post);
        request.AddJsonBody(aluno);

        var response = await _restClient.ExecuteAsync<ResponseMicroService<bool>>(request);

        if (!response.IsSuccessful)
        {
            throw new Exception($"Falha ao adicionar o aluno: {response.Data?.Message ?? response.ErrorMessage}");
        }
    }

    public async Task Update(Aluno aluno)
    {
        var request = new RestRequest($"api/aluno/{aluno.Id}", Method.Put);
        request.AddJsonBody(aluno);

        var response = await _restClient.ExecuteAsync<ResponseMicroService<bool>>(request);

        if (!response.IsSuccessful)
        {
            throw new Exception($"Falha ao editar o aluno id {aluno.Id}: {response.Data?.Message ?? response.ErrorMessage}");
        }
    }

    public async Task Delete(int id)
    {
        var request = new RestRequest($"api/aluno/{id}", Method.Delete);
        var response = await _restClient.ExecuteAsync<ResponseMicroService<bool>>(request);

        if (!response.IsSuccessful)
        {
            throw new Exception($"Falha ao deletar o aluno id {id}: {response.Data?.Message ?? response.ErrorMessage}");
        }
    }

    public async Task<IEnumerable<Aluno>> GetAlunosByIdTurma(int idTurma)
    {
        var request = new RestRequest($"api/aluno/turma/{idTurma}", Method.Get);
        var response = await _restClient.ExecuteAsync<ResponseMicroService<IEnumerable<Aluno>>>(request);
        if (!response.IsSuccessful)
        {
            throw new Exception($"Falha ao consultar os alunos por turma: {response.Data?.Message ?? response.ErrorMessage}");
        }

        return response.Data.Result;
    }
}
