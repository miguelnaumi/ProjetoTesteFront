using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TesteProjetoFront.Services;

namespace TesteProjetoFront.Pages
{
    public class CreateAlunoTurmaModel : PageModel
    {
        private readonly ILogger<CreateAlunoTurmaModel> _logger;

        private readonly IAlunoTurmaService _alunoTurmaService;

        public CreateAlunoTurmaModel(IAlunoTurmaService alunoTurmaService)
        {
            _alunoTurmaService = alunoTurmaService;
        }
        public void OnGet()
        {

        }
    }
}
