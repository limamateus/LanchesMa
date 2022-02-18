using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMa.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Display(Name = " Nome do Lanche")]
        [Required(ErrorMessage ="Informe o Nome do Lanche")]
        [StringLength(200, MinimumLength = 3, ErrorMessage =" Minimo de caracteres {2} e o Maximo é {1}")]
        
        public string LancheName { get; set; }

        [Display(Name = " Nome do Lanche curta ")]
        [Required(ErrorMessage = "Informe o Nome do Lanche curta")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = " Minimo de caracteres {2} e o Maximo é {1}")]
        public string  DescricaoCurta { get; set; }


        [Display(Name = " Nome do Lanche curta ")]
        [Required(ErrorMessage = "Informe o Nome do Lanche curta")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = " Minimo de caracteres {2} e o Maximo é {1}")]
        public string DescricaoDetalhada { get; set; }

        [Display(Name =" Preço do Produto")]
        [Column(TypeName = "Decimal(10,2")]
        public decimal Preco { get; set; }

        [Display(Name ="Caminho da Imagem")]
        [StringLength(200, ErrorMessage = " O {0} deve ter no maximo {1} caracter ")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho da Imagem")]
        [StringLength(200, ErrorMessage = " O {0} deve ter no maximo {1} caracter ")]
        public string ImagemThumbnailUrl { get; set; }

        public bool LanchePreferido { get; set; }

        public bool EmEstoque { get; set; }


        public int CategoriaId { get; set; }

        public virtual Categoria  Categoria { get; set; }


    }
}
