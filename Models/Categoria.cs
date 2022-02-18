using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMa.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage =" Informe o Nome da Categoria")]
        [MinLength(3,ErrorMessage ="Minimo é de {1} letras")]
        [MaxLength(60,ErrorMessage ="Maximo é de {1} letras")]
        [Display(Name = "Nome da Categoria")]
        public string CategoriaNome { get; set; }

        [Required(ErrorMessage = " Informe o Nome da Categoria")]
        [MinLength(3, ErrorMessage = "Minimo é de {1} letras")]
        [MaxLength(60, ErrorMessage = "Maximo é de {1} letras")]
        [Display(Name = "Nome da Categoria")]
        public string DescricaoCurta { get; set; }


        public List<Lanche> Lanches { get; set; }

    }
}
