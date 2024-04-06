using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace TesteProjetoFront.Models
{
    public class Turma
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Curso é obrigatório.")]
        public int IdCurso { get; set; }
        public string? CursoNome { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Ano é obrigatório.")]
        [YearRange(int.MaxValue, ErrorMessage = "Insira um ano válido")]
        public int Ano { get; set; }
        public bool AlunosVinculados { get; set; }
        public List<SelectListItem>? Cursos { get; set; }
    }

}
