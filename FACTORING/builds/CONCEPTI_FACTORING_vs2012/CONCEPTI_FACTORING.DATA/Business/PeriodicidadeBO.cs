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
    public class PeriodicidadeBO
    {

        private PeriodicidadeDAO _DAO = GenericSingleton<PeriodicidadeDAO>.GetInstance();


        #region DAO

        public void SalvarPeriodicidade(Periodicidade _periodicidade)
        {
            try
            {
                if (_periodicidade.COD_PERIODICIDADE == 0)
                    _DAO.Add(_periodicidade);
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


        public List<Periodicidade> GetAll()
        {
            return _DAO.GetAll().ToList<Periodicidade>();
        }

        #endregion


        #region Métodos Públicos

        public Periodicidade GetPeriodicidade(int codPeriodicidade)
        {
            return _DAO.Find(p => p.COD_PERIODICIDADE == codPeriodicidade).FirstOrDefault<Periodicidade>();
        }

        public List<Periodicidade> GetAtivas()
        {
            return _DAO.Find(p => p.ATIVO == true).ToList<Periodicidade>();
        }



        #endregion

    }
}
