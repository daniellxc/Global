using LAB5GED.DOMAIN.Acessorio;
using LAB5GED.DOMAIN.DAO.Interfaces;
using LAB5GED.DOMAIN.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;

namespace LAB5GED.DOMAIN.DAO.Business
{
   public class CaixaBO
    {
       private class CaixaDAO : AbstracCrudDAO<Caixa>, ICaixaDAO
       {
           public CaixaDAO()
           {

           }
       }

       private CaixaDAO _DAO = new CaixaDAO();

       #region Métodos
       public void SalvarCaixa(Caixa _caixa)
       {
           try
           {

               if (_caixa.Registro == 0)
               {

                   _DAO.Add(_caixa);
                   _DAO.SaveChanges();
               }
               else
               {
                   _DAO.Atualizar(_caixa, _caixa.Registro);
               }
           }
           catch (DbEntityValidationException dbex)
           {
               throw new Erros.ErroDeValidacao(dbex);
           }
           catch (DbUpdateException dbuex)
           {
               throw new Erros.ErroGeral("Não foi possível concluir a operação. Verifique se o item não foi cadastrado previamente.");
           }
           catch (Exception ex)
           {
               throw new Erros.ErroGeral("Erro inesperado. " + ex.Message);
           }

       }

       public List<Caixa> GetAll()
       {
           return _DAO.GetAll();
       }

       public Caixa GetByRegistro(int _registroCaixa)
       {
           return _DAO.Find(c => c.Registro == _registroCaixa).FirstOrDefault();
       }

       public List<Caixa> GetCaixasAbertas()
       {
           return _DAO.Find(c => c.Aberta).ToList();
       }


     

       #endregion

    }
}
