using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TesteProjetoFront.Services;

namespace TesteProjetoFront.Pages
{
    public class EditAlunoTurmaModel : PageModel
    {
        private readonly ILogger<EditAlunoTurmaModel> _logger;

        private readonly IAlunoTurmaService _alunoTurmaService;

        public EditAlunoTurmaModel(IAlunoTurmaService alunoTurmaService)
        {
            _alunoTurmaService = alunoTurmaService;
        }
        public void OnGet()
        {

        }
    }
}
