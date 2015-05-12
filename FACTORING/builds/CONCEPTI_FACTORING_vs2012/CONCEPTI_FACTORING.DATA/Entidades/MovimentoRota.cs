using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepti.Factoring.Data.Entidades
{
    [Table("movimentorota")]
   public class MovimentoRota
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("COD_MOVIMENTO_ROTA")]
        public int COD_MOVIMENTO_ROTA { get; set; }

        [Column("COD_MOVIMENTO")]
        [Required(ErrorMessage = "Campo MOVIMENTO não preenchido")]
        public int COD_MOVIMENTO { get; set; }

        [Column("COD_ROTA")]
        [Required(ErrorMessage = "Campo ROTA não preenchido")]
        public int COD_ROTA { get; set; }

        #region Foreign Keys

        [ForeignKey("COD_MOVIMENTO")]
        public virtual Movimento MOVIMENTO_FK { get; set; }

        [ForeignKey("COD_ROTA")]
        public virtual Rota ROTA_FK { get; set; }
        #endregion

        public MovimentoRota() { }
    }
}
