using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepti.Factoring.Data.Entidades
{
    [Table("cidade")]
   public class Cidade
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("COD_CIDADE")]
        public int COD_CIDADE { get; set; }

        [Column("NOME")]
        [Required(ErrorMessage="Campo NOME não preenchido")]
        public string NOME { get; set; }

        [Column("ESTADO")]
        [Required]
        public string ESTADO { get; set; }


        [Column("ATIVO")]
        [Required]
        public bool ATIVO{ get; set; }
        public Cidade() { }
    }
}
