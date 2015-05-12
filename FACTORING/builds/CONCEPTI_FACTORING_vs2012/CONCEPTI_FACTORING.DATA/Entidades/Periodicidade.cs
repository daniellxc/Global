using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepti.Factoring.Data.Entidades
{
    [Table("periodicidade")]
    public class Periodicidade
    {

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("COD_PERIODICIDADE")]
        public int COD_PERIODICIDADE { get; set; }

        [Column("DESCRICAO")]
        [Required(ErrorMessage="Campo DESCRIÇÃO não informado")]
        public string DESCRICAO { get; set; }

        
        [Column("ATIVO")]
        [Required]
        public bool ATIVO{ get; set; }
       

        public Periodicidade() { }
    }
}
