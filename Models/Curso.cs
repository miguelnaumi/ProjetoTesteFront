using System.ComponentModel.DataAnnotations;

namespace TesteProjetoFront.Models
{
    public class Curso
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Duração do curso (Semestres) é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "A duração do curso deve ser maior que zero.")]
        public int DuracaoSemestre { get; set; }
    }


}
