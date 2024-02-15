using System.ComponentModel.DataAnnotations;

namespace AppVendasWeb.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }

        [Required(ErrorMessage = "O campo é Obrigaório!")]
        [Display(Name = "Nome do Produto")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo deve ter no máximo 3 à 100 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Display(Name = "Categoria")]
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }


    }
}
