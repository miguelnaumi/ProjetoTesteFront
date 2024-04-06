using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TesteProjetoFront.Views.Turma
{
    public class IndexTurmaModel : PageModel
    {
        private readonly ILogger<IndexTurmaModel> _logger;

        public IndexTurmaModel(ILogger<IndexTurmaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
