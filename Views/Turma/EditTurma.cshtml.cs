using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TesteProjetoFront.Pages
{
    public class EditTurmaModel : PageModel
    {
        private readonly ILogger<EditTurmaModel> _logger;

        public EditTurmaModel(ILogger<EditTurmaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
