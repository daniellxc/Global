using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepti.Factoring.Data.Entidades
{
    [Table("movimento")]
    public class Movimento
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("COD_MOVIMENTO")]
        public int COD_MOVIMENTO { get; set; }

        [Column("COD_TIPO_MOVIMENTO")]
        [Required(ErrorMessage = "Campo TIPO não preenchido")]
        public int COD_TIPO_MOVIMENTO { get; set; }

        [Column("MOMENTO")]
        [Required(ErrorMessage = "Campo MOMENTO não preenchido")]
        public DateTime MOMENTO { get; set; }

        [Column("VALOR")]
        [Required(ErrorMessage = "Campo VALOR não preenchido")]
        public decimal VALOR { get; set; }

        #region Foreign Keys

        [ForeignKey("COD_TIPO_MOVIMENTO")]
        public virtual TipoMovimento TIPOMOVIMENTO_FK { get; set; }

        
        #endregion

        public Movimento() { }
    }
}
