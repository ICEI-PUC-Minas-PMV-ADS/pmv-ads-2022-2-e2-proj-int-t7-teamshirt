using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace team_shirt.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [Required]
        public double Preco { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        public string CaminhoImagem { get; set; }

        [Required]
        public string NomeImagem { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
