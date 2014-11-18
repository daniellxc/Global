using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace LAB5GED.DOMAIN.Entidades
{
    [Table("tb_caixa")]
    public class Caixa
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("registro")]
        public int Registro { get; set; }

        [Column("id_caixa")]
        [Required(ErrorMessage="campo obrigatório")]
        [Display(Name="Identificação")]
        [StringLength(100)]
        public string IdCaixa { get; set; }

        [Column("descricao")]
        [DataType(DataType.Text)]
        [Display(Name = "Descrição")]
        [StringLength(255)]
        public string Descricao { get; set; }

        [Column("localizacao")]
        [Display(Name = "Localização")]
        [StringLength(100)]
        public string Localizacao { get; set; }

        [Column("aberta")]
        [Required(ErrorMessage="campo obrigatório")]
        public bool Aberta { get; set; }

        public virtual List<Documento> Documentos { get; set; }

        public Caixa()
        {

        }

    }
}
