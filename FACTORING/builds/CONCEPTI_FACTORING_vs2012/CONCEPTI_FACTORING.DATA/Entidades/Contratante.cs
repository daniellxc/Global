using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepti.Factoring.Data.Entidades
{
    [Table("contratante")]
   public class Contratante
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("COD_CONTRATANTE")]
        public int COD_CONTRATANTE { get; set; }

        [Column("COD_ESCOLARIDADE")]
        [Required(ErrorMessage="Campo ESCOLARIDADE não informado")]
        public int COD_ESCOLARIDADE { get; set; }

        [Column("CIDADE_RES")]
        [Required(ErrorMessage = "Campo CIDADE não informado")]
        public int CIDADE_RES { get; set; }

        [Column("CIDADE_COM")]
        public int CIDADE_COM { get; set; }

        [Column("NOME")]
        [Required(ErrorMessage = "Campo NOME não informado")]
        public string NOME{ get; set; }

        [Column("RG")]
        [Required(ErrorMessage = "Campo RG não informado")]
        public string RG { get; set; }

        [Column("ORG_EXP")]
        [Required(ErrorMessage = "Campo ORG. EXP RG não informado")]
        public string ORG_EXP { get; set; }

        [Column("DATA_EXP")]
        [Required(ErrorMessage = "Campo DATA DE EXPEDIÇÃO não informado")]
        public DateTime DATE_EXP { get; set; }

        [Column("CPF")]
        public string CPF { get; set; }

        [Column("SEXO")]
        [Required(ErrorMessage = "Campo SEXO não informado")]
        public string SEXO { get; set; }

        [Column("LIMITE")]
        [Required(ErrorMessage = "Campo LIMITE não informado")]
        public decimal LIMITE { get; set; }

        [Column("NOME_PAI")]
        public string NOME_PAI{ get; set; }

        [Column("NOME_MAE")]
        public string NOME_MAE { get; set; }


        [Column("RUA_RES")]
        [Required(ErrorMessage = "Campo RUA não informado")]
        public string RUA_RES { get; set; }

        [Column("BAIRRO_RES")]
        [Required(ErrorMessage = "Campo BAIRRO não informado")]
        public string BAIRRO_RES { get; set; }

        [Column("NUMERO_RES")]
        [Required(ErrorMessage = "Campo NÚMERO não informado")]
        public string NUMERO_RES { get; set; }

        [Column("TEL_RES")]
        [Required(ErrorMessage = "Campo TELEFONE não informado")]
        public string TEL_RES { get; set; }

        [Column("RUA_COM")]
        public string RUA_COM { get; set; }

        [Column("BAIRRO_COM")]
        public string BAIRRO_COM { get; set; }

        [Column("NUMERO_COM")]
        public string NUMERO_COM { get; set; }

        [Column("TEL_COM")]
        public string TEL_COM { get; set; }

        [Column("OBS")]
        public string OBS { get; set; }

        [Column("COD_AREA")]
        [Required(ErrorMessage = "Campo ÁREA não informado")]
        public int COD_AREA { get; set; }

        [Column("DIA_INDISPONIVEL")]
        public int DIA_INDISPONIVEL { get; set; }

        #region Foreign Keys

        [ForeignKey("COD_ESCOLARIDADE")]
        public virtual Escolaridade ESCOLARIDADE_FK { get; set; }

        [ForeignKey("CIDADE_RES")]
        public virtual Cidade CIDADE_RES_FK { get; set; }

        [ForeignKey("CIDADE_COM")]
        public virtual Cidade CIDADE_COM_FK { get; set; }

        [ForeignKey("COD_AREA")]
        public virtual Area AREA_FK { get; set; }

        [ForeignKey("DIA_INDISPONIVEL")]
        public virtual Dia DIA_FK { get; set; }

        #endregion

        public Contratante() { }




    }
}
