using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Transactions;
using System.Data;
using Concepti.Factoring.Data.Entidades;
using Concepti.Factoring.Data.DAO_Classes;
using Concepti.Factoring.Data;
using System.Collections;

namespace Concepti.Factoring.Business.Classes
{
   public class RotaBO
    {
       Rota _rota;
       RotaDAO _rotaDAO;

       public RotaBO()
       {

       }

       public RotaBO(Rota Rota)
       {
           _rota = Rota;
       }

        #region Métodos

       /// <summary>
       /// Método que finaliza a rota zerando o fundo.
       /// </summary>
       public void FecharRota()
       {
           
               try
               {
                   _rotaDAO = new RotaDAO();
                   _rota = _rotaDAO.Find(r => r.COD_ROTA == _rota.COD_ROTA).First<Rota>();
                   _rota.DATA_FIM = DateTime.Now;
                   _rota.CONCLUIDA = true;
                   _rota.FUNDO = 0;
                   _rotaDAO.SaveChanges();
               }
               catch
               {
                   throw new Exception("Não foi possível finalizar rota.");
               }
          
       }

       public void RegistrarMovimento(decimal valor, int codTipoMovimento)
       {
           bool sucesso;
           Movimento movimento = new Movimento();
           MovimentoRota movimentoRota = new MovimentoRota();
           MovimentoDAO movimentoDao = new MovimentoDAO();
           MovimentoRotaDAO movimentoRotaDao = new MovimentoRotaDAO();
           using (TransactionScope scope = new TransactionScope())
           {
               try
               {
                   movimento.COD_TIPO_MOVIMENTO = codTipoMovimento;
                   movimento.MOMENTO = DateTime.Now;
                   movimento.VALOR = valor;
                   movimentoDao.Add(movimento);
                   movimentoDao.SaveChanges();

                   movimentoRota.COD_MOVIMENTO = movimento.COD_MOVIMENTO;
                   movimentoRota.COD_ROTA = _rota.COD_ROTA;
                   movimentoRotaDao.Add(movimentoRota);
                   movimentoRotaDao.SaveChanges();

                   sucesso = true;

               }
               catch
               {
                   sucesso = false;
                   throw new EntityException("Erro.");
               }

               if (sucesso)
               {
                   scope.Complete();
               }

           }

       }


       //public bool podeContratar()
       //{
       //    IQueryable consulta = new Vendedor(_rota.vendedor).buscarContratosFirmados();

       //    decimal valor = 0;
       //    try
       //    {
       //        foreach (contrato c in consulta)
       //        {
       //            valor += c.VALOR;
       //        }
             

       //        return valor <= _rota.FUNDO;
       //    }
       //    catch (Exception ex)
       //    {
       //        return false;
       //        throw ex;
       //    }

       //}



       public decimal pegarSaidaRota()
       {
           Contexto context = new Contexto();
           decimal retorno = 0;
           var consulta = from a in context.Movimentos
                          where (from b in context.MovimentosRotas where b.COD_ROTA == _rota.COD_ROTA select b.COD_MOVIMENTO).Contains(a.COD_MOVIMENTO) && a.COD_TIPO_MOVIMENTO == 1
                          select new { a.VALOR };
           foreach (var x in consulta)
           {
               retorno += x.VALOR == null ? 0 : decimal.Parse(x.VALOR.ToString());
           }

           return retorno;
       }

       public decimal pegarRetornoRota()
       {
           Contexto context = new Contexto();
           decimal retorno = 0;
           var consulta = from a in context.Movimentos
                          where (from b in context.MovimentosRotas where b.COD_ROTA == _rota.COD_ROTA select b.COD_MOVIMENTO).Contains(a.COD_MOVIMENTO) && a.COD_TIPO_MOVIMENTO == 2
                          select new { a.VALOR };
           foreach (var x in consulta)
           {
               retorno = x.VALOR==null?0:decimal.Parse(x.VALOR.ToString());
           }

           return retorno;
       }

       public decimal pegarTotalBoletosBaixados()
       {
           Contexto context = new Contexto();
           decimal retorno = 0;
           var consulta = from a in context.Movimentos
                          where (from b in context.MovimentosRotas where b.COD_ROTA == _rota.COD_ROTA && b.MOVIMENTO_FK.COD_TIPO_MOVIMENTO==3 select b.COD_MOVIMENTO).Contains(a.COD_MOVIMENTO)
                          select new {a.VALOR};
           foreach (var x in consulta)
           {
               retorno += x.VALOR == null ? 0 : decimal.Parse(x.VALOR.ToString());
           }

           return retorno;
       }

       public IList buscarDadosDosContratosFirmados()
       {
           Contexto context = new Contexto();

           var consulta = from a in context.Contratos
                          where a.ROTA_FK.COD_ROTA == _rota.COD_ROTA
                          select new { a.CONTRATANTE_FK.NOME, a.VALOR, a.DATA_ABERTURA };

           return consulta.ToList();
       }

       public IList buscarDespesas()
       {
           Contexto context = new Contexto();

           var consulta = from a in context.ItensDespesa
                          where a.COD_ROTA == _rota.COD_ROTA
                          join b in context.TiposDespesa
                          on a.COD_TIPO_DESPESA equals b.COD_TIPO_DESPESA
                          select new { b.DESCRICAO_DESPESA, a.VALOR };
           return consulta.ToList();

       }

        #endregion

    }
}
