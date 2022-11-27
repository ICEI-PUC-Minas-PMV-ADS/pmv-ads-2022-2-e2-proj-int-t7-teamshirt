using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace team_shirt.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage ="O nome do Produto é obrigatorio")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O preço do Produto é obrigatorio")]
        [Display(Name = "Preço")]
        public double Preco { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        [Display(Name = "Caminho da Imagem")]
        public string CaminhoImagem { get; set; }

        [Required]
        [Display(Name = "Nome da Imagem")]
        public string NomeImagem { get; set; }

        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }

        
        public virtual Categoria Categoria { get; set; }
    }
}
