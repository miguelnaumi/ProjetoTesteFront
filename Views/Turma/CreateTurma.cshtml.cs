using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TesteProjetoFront.Services;

namespace TesteProjetoFront.Pages
{
    public class CreateTurmaModel : PageModel
    {
        private readonly ILogger<CreateTurmaModel> _logger;

        private readonly ITurmaService _turmaService;

        public CreateTurmaModel(ITurmaService turmaService)
        {
            _turmaService = turmaService;
        }
        public void OnGet()
        {

        }
    }
}
