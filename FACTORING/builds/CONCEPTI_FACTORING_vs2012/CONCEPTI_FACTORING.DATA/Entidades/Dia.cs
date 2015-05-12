using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepti.Factoring.Data.Entidades
{
    [Table("dia")]
   public class Dia
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("cod_dia")]
        public int COD_DIA { get; set; }

        [Column("descricao")]
        [Required]
        public string DESCRICAO { get; set; }

        public Dia() { }
    }
}
