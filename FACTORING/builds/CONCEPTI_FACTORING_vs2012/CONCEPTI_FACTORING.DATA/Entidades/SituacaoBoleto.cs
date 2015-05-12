using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepti.Factoring.Data.Entidades
{
    [Table("situacao_boleto")]
   public class SituacaoBoleto
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("COD_SITUACAO_BOLETO")]
        public int COD_SITUACAO_BOLETO { get; set; }

        [Column("DESCRICAO")]
        [Required(ErrorMessage="Campo DESCRIÇÃO não preenchido")]
        public string DESCRICAO { get; set; }

        public SituacaoBoleto() { }
    }
}
