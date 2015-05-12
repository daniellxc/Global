using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Concepti.Factoring.Data.Entidades
{
    [Table("area")]
    public class Area
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("COD_AREA")]
        public int COD_AREA { get; set; }

        [Column("NOME")]
        public string NOME { get; set; }

        [Column("DESCRICAO")]
        public string DESCRICAO { get; set; }

        public Area(){}
    }
}
