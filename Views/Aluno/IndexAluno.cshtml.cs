using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TesteProjetoFront.Views.Aluno
{
    public class IndexAlunoModel : PageModel
    {
        private readonly ILogger<IndexAlunoModel> _logger;

        public IndexAlunoModel(ILogger<IndexAlunoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
