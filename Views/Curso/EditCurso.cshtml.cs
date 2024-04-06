using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TesteProjetoFront.Pages
{
    public class EditCursoModel : PageModel
    {
        private readonly ILogger<EditCursoModel> _logger;

        public EditCursoModel(ILogger<EditCursoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
