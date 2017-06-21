
using System.ComponentModel.DataAnnotations;

namespace BaseModels
{
    public class Produto
    {
        [Key]
        public int ProdutoID { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(10, ErrorMessage = "Tamanho máximo é 10 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [Required]
        public bool Ativo { get; set; }

        [Display(Name = "Categoria")]
        public int CategoriaID { set; get; }

        [Display(Name ="Categoria")]
        public virtual Categoria _Categoria { get; set; }
    }
}
