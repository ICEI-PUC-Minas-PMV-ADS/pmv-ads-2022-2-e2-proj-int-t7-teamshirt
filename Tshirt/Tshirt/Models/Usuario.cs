using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tshirt.Models
{

	[Table("Usuarios")]
	public class Usuario
    {
		   [Key]
			public int Id { get; set; }

			[Display(Name = "Email")]
			[Required(ErrorMessage = "Obrigatório informar o email")]
			public string Nome { get; set; }

			[Display(Name = "Senha")]
			[Required(ErrorMessage = "Obrigatório informar a senha")]
			[DataType(DataType.Password)]
			public string Senha { get; set; }

		
	}
}
