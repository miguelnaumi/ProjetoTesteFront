using TesteProjetoFront.Models;

namespace TesteProjetoFront.Services
{
    public interface IHomeService
    {
        Task<HomeModel> GetHomeInfo();
    }
}