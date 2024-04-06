using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TesteProjetoFront.Views.Aluno
{
    public class AlunoPorTurmaModel : PageModel
    {
        private readonly ILogger<AlunoPorTurmaModel> _logger;

        public AlunoPorTurmaModel(ILogger<AlunoPorTurmaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
