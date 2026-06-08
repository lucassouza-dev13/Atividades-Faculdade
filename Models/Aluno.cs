using System.ComponentModel.DataAnnotations;

namespace CadastroAluno.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "Nome deve ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "RA é obrigatório")]
        [StringLength(20, ErrorMessage = "RA deve ter no máximo 20 caracteres")]
        public string RA { get; set; }

        [Required(ErrorMessage = "Curso é obrigatório")]
        [StringLength(100, ErrorMessage = "Curso deve ter no máximo 100 caracteres")]
        public string Curso { get; set; }

        [Required(ErrorMessage = "Data de Nascimento é obrigatória")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}