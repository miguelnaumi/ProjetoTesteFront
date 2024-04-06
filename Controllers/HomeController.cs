using Microsoft.AspNetCore.Mvc;
using TesteProjetoFront.Models;
using TesteProjetoFront.Repositories;
using TesteProjetoFront.Services;

namespace TesteProjetoFront.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
