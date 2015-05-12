


using Concepti.Factoring.Data;
using Concepti.Factoring.Data.DAO_Classes;
using Concepti.Factoring.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;


namespace Concepti.Factoring.Business
{
    public class ContratanteBO
    {

        #region DAO

        private  ContratanteDAO _DAO =  GenericSingleton<ContratanteDAO>.GetInstance();

        #endregion
        Contratante _contratante;

        public ContratanteBO() 
        {
        }

        public ContratanteBO(Contratante _Contratante)
        {
            this._contratante = _Contratante;
        }

        public void SalvarContratante(Contratante _contratante)
        {
            try
            {
                if (_contratante.COD_CONTRATANTE == 0)
                    _DAO.Add(_contratante);
                _DAO.SaveChanges();
              
            }
            catch (DbEntityValidationException dbex)
            {
                throw dbex;

            }
            catch (Exception ex)
            { throw ex; }

        }

        public Contratante GetContratante(int cod)
        {
            return _DAO.Find(c => c.COD_CONTRATANTE == cod).FirstOrDefault<Contratante>();
        }


        public IQueryable buscarContratantes(string nomeContratante)
        {
            Contexto context = new Contexto();

            var consulta = from a in context.Contratantes
                          // where a.NOME.Contains(nomeContratante)
                           join b in context.Areas on a.COD_AREA equals b.COD_AREA
                           where a.NOME.Contains(nomeContratante)
                           select new { a.COD_CONTRATANTE, a.NOME, a.CPF, a.LIMITE, a.TEL_RES, nome_area = b.NOME };
                          

            return consulta;

        }

        public List<Contratante> Consultar(string nomeContratante)
        {
            return _DAO.Find(c=>c.NOME.Contains(nomeContratante)).ToList<Contratante>();
        }
    }
}
