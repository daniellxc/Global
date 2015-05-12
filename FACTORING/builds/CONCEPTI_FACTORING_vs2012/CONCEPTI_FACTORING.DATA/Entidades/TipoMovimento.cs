using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepti.Factoring.Data.Entidades
{
    [Table("tipo_movimento")]
   public class TipoMovimento
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("COD_TIPO_MOVIMENTO")]
        public int COD_TIPO_MOVIMENTO { get; set; }

        [Column("DESCRICAO")]
        [Required(ErrorMessage = "Campo DESCRIÇÃO não preenchido")]
        public string DESCRICAO { get; set; }

        public TipoMovimento() { }
    }
}
