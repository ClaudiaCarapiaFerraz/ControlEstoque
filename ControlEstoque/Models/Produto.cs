using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlEstoque.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome (*)")]
        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Display(Name = "Valor do Produto (*)")]
        [Required(ErrorMessage = "Obrigatório informar o valor do produto!")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorProduto { get; set; }

        [Display(Name = "Quantidade (*)")]
        [Required(ErrorMessage = "Obrigatório informar a quantidade!")]
        public int Quantidade { get; set; }

        [Display(Name = "Número da Nota Fiscal (*)")]
        [Required(ErrorMessage = "Obrigatório o número da nota fiscal!")]
        public int NumNotaFiscal { get; set; }

        [Required(ErrorMessage = "Obrigatório a Descrição do produto!")]
        [Display(Name = "Descrição do Produto (*)")]
        public string DescricaoProduto { get; set; }

        [Display(Name = "Código do Usuário")]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario? Usuario { get; set; }

    }
}
