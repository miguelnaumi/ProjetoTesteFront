using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using TesteProjetoFront.Models;
using TesteProjetoFront.Repositories;
using TesteProjetoFront.Services;

namespace TesteProjetoFront.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public async Task<IActionResult> Index()
        {
            var homeInfo = await _homeService.GetHomeInfo();
            return View(homeInfo);
        }
    }
}
