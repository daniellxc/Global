using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepti.Factoring.Data.Entidades
{
    [Table("tipo_despesa")]
    public class TipoDespesa
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("COD_TIPO_DESPESA")]
        public int COD_TIPO_DESPESA { get; set; }

        [Column("DESCRICAO_DESPESA")]
        [Required(ErrorMessage="Campo DESCRIÇÃO DESPESA não preenchido")]
        public string DESCRICAO_DESPESA { get; set; }

        public TipoDespesa() { }
    }
}
