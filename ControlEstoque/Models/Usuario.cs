using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlEstoque.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome (*)")]
        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Name { get; set; }

        [Display(Name = "E-mail (*)")]
        [Required(ErrorMessage = "Obrigatório informar o email!")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.(com|org|net|gov|br)$", ErrorMessage = "Por favor, digite um e-mail válido!")]
        public string Email { get; set; }

        [Display(Name = "Senha (*)")]
        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }

        public ICollection<Produto> Produtos { get; set; }
        
    }
}
