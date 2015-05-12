using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;
using System.Data;
using Concepti.Factoring.Data.Entidades;
using Concepti.Factoring.Data;

namespace Concepti.Factoring.Business.Classes
{
   public class VendedorBO
   {

       Vendedor _vendedor;

       #region Construtores

       public VendedorBO()
       {

       }
       
       public VendedorBO(Vendedor _Vendedor)
       {
           this._vendedor = _Vendedor; 

       }

       

       #endregion

       #region Métodos
       /// <summary>
       /// Método que retorna os vendedores que não possuem rotas abertas.
       /// </summary>
       /// <returns></returns>
       public List<Vendedor> buscarVendedoresSemRota()
       {
           Contexto context = new Contexto();

           var consulta = from a in context.Vendedores
                          where !(from r in context.Rotas where r.CONCLUIDA == false select r.COD_VENDEDOR).Contains(a.COD_VENDEDOR)
                          select a;
           return consulta.ToList<Vendedor>();

       }

       /// <summary>
       /// Método que retornar os vendedores que possuem rota em aberto.
       /// </summary>
       /// <returns></returns>
       public List<Vendedor> buscaVendedoresComRota()
       {
           Contexto context = new Contexto();


           var consulta = from a in context.Vendedores
                          where (from r in context.Rotas where r.CONCLUIDA == false select r.COD_VENDEDOR).Contains(a.COD_VENDEDOR)
                          select a;
           return consulta.ToList<Vendedor>();
       }

    public IList pegarInformacoesRotasFechadasPeriodo(DateTime inicio, DateTime fim)
       {
           Contexto context = new Contexto();
           var consulta = from a in context.Rotas
                                 where (from b in context.Vendedores where b.COD_VENDEDOR == _vendedor.COD_VENDEDOR select b.COD_VENDEDOR).Contains(a.COD_VENDEDOR)
                                 && a.DATA_INICIO >= inicio && a.DATA_FIM <= fim && a.CONCLUIDA ==true
                                 join d in context.MovimentosRotas 
                                 on a.COD_ROTA equals d.COD_ROTA
                                 join e in context.Movimentos 
                                 on d.COD_MOVIMENTO equals e.COD_MOVIMENTO 
                                 where e.COD_TIPO_MOVIMENTO == 1
                                 select new {a.COD_ROTA,a.DATA_INICIO,a.DATA_FIM,e.VALOR,};

           return consulta.ToList() ;              

       }

       /// <summary>
       /// Retorna contratos firmados na rota atual
       /// </summary>
       /// <returns></returns>
       public IList buscarDadosDosContratosFirmadosAtuais()
       {
           Contexto context = new Contexto();

           var consulta = from a in context.Contratos
                          where a.ROTA_FK.VENDEDOR_FK.COD_VENDEDOR == this._vendedor.COD_VENDEDOR
                          && (from r in context.Rotas where r.CONCLUIDA == false select r.COD_ROTA).Contains(a.ROTA_FK.COD_ROTA)
                          select new {a.CONTRATANTE_FK.NOME,a.VALOR,a.DATA_ABERTURA};

           return consulta.ToList();
       }

       


       public List<Contrato> buscarContratosFirmados()
       {
           Contexto context = new Contexto();

           var consulta = from a in context.Contratos
                          where a.ROTA_FK.VENDEDOR_FK.COD_VENDEDOR == this._vendedor.COD_VENDEDOR
                          && (from r in context.Rotas where r.CONCLUIDA == false select r.COD_ROTA).Contains(a.ROTA_FK.COD_ROTA)
                          select a;

           return consulta.ToList<Contrato>();
       }

       public Rota buscarRotaAberta()
       {
           Contexto context = new Contexto();

           var consulta = from a in context.Rotas
                          where a.COD_VENDEDOR == _vendedor.COD_VENDEDOR && a.CONCLUIDA == false
                          select a;
           try
           {
               return consulta.AsEnumerable().First<Rota>();
           }
           catch
           {
               return new Rota();
           }
       }

       public bool possuiRotaAberta()
       {
           Contexto context = new Contexto();

           var consulta = from a in context.Rotas
                          where a.COD_VENDEDOR == _vendedor.COD_VENDEDOR && a.CONCLUIDA == false
                          select a;
           foreach (var x in consulta)
           {
               return  x.COD_ROTA != null;
           }

           return false;
       }
       
 
       #endregion
   }
}
