using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepti.Factoring.Data.Entidades
{
    [Table("contrato")]
    public class Contrato
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("COD_CONTRATO")]
        public int COD_CONTRATO { get; set; }

        [Column("COD_CONTRATANTE")]
        [Required(ErrorMessage="Campo CONTRATANTE não informado")]
        public int COD_CONTRATANTE { get; set; }

        [Column("COD_PERIODICIDADE")]
        [Required(ErrorMessage = "Campo PERIODICIDADE não informado")]
        public int COD_PERIODICIDADE { get; set; }

        [Column("VALOR")]
        [Required(ErrorMessage = "Campo VALOR não informado")]
        public decimal VALOR { get; set; }

        [Column("PERIODO")]
        [Required(ErrorMessage = "Campo PERÍODO não informado")]
        public int PERIODO { get; set; }

        [Column("JUROS")]
        [Required(ErrorMessage = "Campo JUROS não informado")]
        public decimal JUROS { get; set; }

        [Column("DATA_ABERTURA")]
        [Required(ErrorMessage = "Campo DATA DE ABERTURA não informado")]
        public DateTime DATA_ABERTURA { get; set; }

        [Column("COD_ROTA")]
        [Required(ErrorMessage = "Campo ROTA não informado")]
        public int COD_ROTA { get; set; }

        [Column("ATIVO")]
        [Required(ErrorMessage = "Campo ATIVO não informado")]
        public bool ATIVO { get; set; }

        #region Foreign Keys

        [ForeignKey("COD_CONTRATANTE")]
        public virtual Contratante CONTRATANTE_FK { get; set; }

        [ForeignKey("COD_PERIODICIDADE")]
        public virtual Periodicidade PERIODICIDADE_FK { get; set; }

        [ForeignKey("COD_ROTA")]
        public virtual Rota ROTA_FK { get; set; }
        #endregion

        public Contrato() { }



    }
}
