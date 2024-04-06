using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TesteProjetoFront.Pages
{
    public class CreateAlunoModel : PageModel
    {
        private readonly ILogger<CreateAlunoModel> _logger;

        public CreateAlunoModel(ILogger<CreateAlunoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
