using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepti.Factoring.Data.Entidades
{
    [Table("vendedor")]
    public class Vendedor
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("COD_VENDEDOR")]
        public int COD_VENDEDOR { get; set; }

       [Column("NOME")]
       [Required(ErrorMessage="Campo NOME não preenchido")]
       public string NOME{ get; set; }

       [Column("DATA_CONTRATACAO")]
       [Required(ErrorMessage = "Campo DATA CONTRATAÇÃO não preenchido")]
       public DateTime DATA_CONTRATACAO { get; set; }

       [Column("RG")]
       public string RG { get; set; }

       [Column("TELEFONE")]
       public string TELEFONE { get; set; }

       [Column("CELULAR")]
       public string CELULAR { get; set; }

       [Column("COD_AREA")]
       [Required(ErrorMessage = "Campo ÁREA não preenchido")]
       public int COD_AREA { get; set; }

        #region Foreign Keys

        [ForeignKey("COD_AREA")]
        public virtual Area AREA_FK { get; set; }

        #endregion

        public Vendedor() { }


    }
}
