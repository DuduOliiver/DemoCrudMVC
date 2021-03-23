using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="Campo título é obrigatório")]
        [StringLength(60, MinimumLength = 4  , ErrorMessage="Precisa ter entre 3 ou 60 carácteres")]
        public string Titulo { get; set; }
        

        [DataType(DataType.DateTime, ErrorMessage = "Data inválida")]
        [Required(ErrorMessage="Campo Data de Lancamento é obrigatório")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00c00-\u00FF""' \w-]*$", ErrorMessage = "Genero em formato inválido")]
        [StringLength(30,MinimumLength = 3, ErrorMessage="Precisa ter entre 3 a 30 carácteres"), Required(ErrorMessage="O campo gênero é obrigatório")]
        public string Genero { get; set; }

        [Range(1,1000, ErrorMessage="Valor de 1 a 1000")]
        [Required(ErrorMessage="Campo valor obrigatório")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage="Campo avaliação é obrigatório")]
        [Display(Name = "Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage="Somente números de 1 a 5")]
        
        [Range(1,5, ErrorMessage = "O campo avaliação deve ter um número entre 0 a 5")]
        public int Avaliacao { get; set; }
    }
}
