using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepti.Factoring.Data.Entidades
{
    [Table("boleto")]
   public class Boleto
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("COD_BOLETO")]
        public int COD_BOLETO { get; set; }

        [Column("COD_CONTRATO")]
        [Required(ErrorMessage="Campo CONTRATO não preenchido")]
        public int COD_CONTRATO { get; set; }

        [Column("COD_SITUACAO_BOLETO")]
        [Required(ErrorMessage = "Campo SITUACAO BOLETO não preenchido")]
        public int COD_SITUACAO_BOLETO { get; set; }

        [Column("DATA_VENCIMENTO")]
        [Required(ErrorMessage = "Campo VENCIMENTO não preenchido")]
        public DateTime DATA_VENCIMENTO { get; set; }

        [Column("DATA_PAGAMENTO")]
        [Required(ErrorMessage = "Campo DATA PAGAMENTO não preenchido")]
        public DateTime DATA_PAGAMENTO { get; set; }

        [Column("VALOR")]
        [Required(ErrorMessage = "Campo VALOR não preenchido")]
        public decimal VALOR { get; set; }

        [Column("PARCELA")]
        [Required(ErrorMessage = "Campo PARCELA não preenchido")]
        public int PARCELA { get; set; }

        #region Foreign Keys

        [ForeignKey("COD_CONTRATO")]
        public virtual Contrato CONTRATO_FK { get; set; }

        [ForeignKey("COD_SITUACAO_BOLETO")]
        public virtual SituacaoBoleto SITUACAO_BOLETO_FK { get; set; }

        #endregion

        public Boleto() { }



    }
}
