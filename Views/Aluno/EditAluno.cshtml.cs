using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TesteProjetoFront.Pages
{
    public class EditAlunoModel : PageModel
    {
        private readonly ILogger<EditAlunoModel> _logger;

        public EditAlunoModel(ILogger<EditAlunoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
