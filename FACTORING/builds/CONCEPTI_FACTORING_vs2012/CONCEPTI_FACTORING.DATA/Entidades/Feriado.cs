using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepti.Factoring.Data.Entidades
{
      [Table("feriado")]
    public class Feriado
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("COD_FERIADO")]
        public int COD_FERIADO { get; set; }

        [Column("DIAMES")]
        [Required]
        public string DIAMES { get; set; }

        [Column("DESCRICAO")]
        [Required(ErrorMessage="O campo DESCRIÇÃO não foi preenchido")]
        public string DESCRICAO { get; set; }

        public Feriado() { }
    }
}
