using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TesteProjetoFront.Pages
{
    public class CreateCursoModel : PageModel
    {
        private readonly ILogger<CreateCursoModel> _logger;

        public CreateCursoModel(ILogger<CreateCursoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
