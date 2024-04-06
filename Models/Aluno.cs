using System.ComponentModel.DataAnnotations;

namespace TesteProjetoFront.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }
        public int? IdTurma { get; set; }
        public string? Turma { get; set; }
        public int Semestre { get; set; } = 1;
        [Required(ErrorMessage = "O campo Usuário é obrigatório.")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "A Senha deve ter no mínimo 6 caracteres.")]
        public string Senha { get; set; }
    }
}
