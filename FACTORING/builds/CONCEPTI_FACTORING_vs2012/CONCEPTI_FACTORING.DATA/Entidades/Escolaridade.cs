using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepti.Factoring.Data.Entidades
{
    [Table("escolaridade")]
    public class Escolaridade
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("COD_ESCOLARIDADE")]
        public int COD_ESCOLARIDADE { get; set; }

        [Column("DESCRICAO")]
        [Required(ErrorMessage="Campo DESCRICAO não preenchido")]
        public string DESCRICAO { get; set; }

        public Escolaridade() { }
    }
}
