using Concepti.Factoring.Data.DAO_Classes;
using Concepti.Factoring.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepti.Factoring.Data.Business
{
   public class CidadeBO
    {
       private CidadeDAO _DAO = GenericSingleton<CidadeDAO>.GetInstance();

        #region DAO

       public void SalvarCidade(Cidade _cidade)
       {
           try
           {
               if (_cidade.COD_CIDADE == 0)
                   _DAO.Add(_cidade);
               _DAO.SaveChanges();
           }
           catch (DbEntityValidationException dbex)
           {
               throw dbex;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

        #endregion


        #region Métodos Públicos

       public Cidade GetCidade(int codCidade)
       {
           return _DAO.Find(c => c.COD_CIDADE == codCidade).FirstOrDefault<Cidade>();
       }

       public string[] GetUf()
       {
           return _DAO.GetAll().Select(c => c.ESTADO).Distinct().ToArray();

       }

       public List<Cidade> GetAtivas()
       {
           return _DAO.Find(c => c.ATIVO == true).ToList<Cidade>();
       }

        #endregion
    }
}
