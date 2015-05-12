using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepti.Factoring.Data.Entidades
{
    [Table("rota")]
    public class Rota
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("COD_ROTA")]
        public int COD_ROTA { get; set; }

        [Column("DATA_INICIO")]
        [Required(ErrorMessage="Campo DATA DE INÍCIO não preenchido")]
        public DateTime DATA_INICIO { get; set; }

        [Column("DATA_FIM")]
        [Required(ErrorMessage = "Campo DATA DE FIM não preenchido")]
        public DateTime DATA_FIM { get; set; }

        [Column("FUNDO")]
        [Required(ErrorMessage = "Campo FUNDO não preenchido")]
        public decimal FUNDO { get; set; }

        [Column("COD_VENDEDOR")]
        [Required(ErrorMessage = "Campo VENDEDOR não preenchido")]
        public int COD_VENDEDOR { get; set; }

        [Column("CONCLUIDA")]
        [Required(ErrorMessage = "Campo CONCLUÍDA não preenchido")]
        public bool CONCLUIDA { get; set; }

        #region Foreign Keys

        [ForeignKey("COD_VENDEDOR")]
        public virtual Vendedor VENDEDOR_FK { get; set; }

        #endregion
        public Rota() { }

    }
}
