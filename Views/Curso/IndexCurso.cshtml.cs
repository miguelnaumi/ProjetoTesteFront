using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TesteProjetoFront.Views.Curso
{
    public class IndexCursoModel : PageModel
    {
        private readonly ILogger<IndexCursoModel> _logger;

        public IndexCursoModel(ILogger<IndexCursoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
