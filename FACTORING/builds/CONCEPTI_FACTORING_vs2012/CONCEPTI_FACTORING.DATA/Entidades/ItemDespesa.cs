using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepti.Factoring.Data.Entidades
{
    [Table("item_despesa")]
    public class ItemDespesa
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("COD_ITEM_DESPESA")]
        public int COD_ITEM_DESPESA { get; set; }

        [Column("COD_ROTA")]
        [Required(ErrorMessage = "Campo ROTA não preenchido")]
        public int COD_ROTA { get; set; }

        [Column("COD_TIPO_DESPESA")]
        [Required(ErrorMessage = "Campo TIPO DE DESPESA não preenchido")]
        public int COD_TIPO_DESPESA { get; set; }

        [Column("VALOR")]
        [Required(ErrorMessage = "Campo VALOR não preenchido")]
        public decimal VALOR { get; set; }

        #region Foreign Keys

        [ForeignKey("COD_ROTA")]
        public virtual Rota ROTA_FK { get; set; }

        [ForeignKey("COD_TIPO_DESPESA")]
        public virtual TipoDespesa TIPODESPESA_FK { get; set; }

        #endregion

        public ItemDespesa() { }

    }
}
