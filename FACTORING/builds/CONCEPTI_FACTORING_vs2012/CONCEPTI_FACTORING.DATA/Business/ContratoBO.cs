using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;
using System.Data;
using Concepti.Factoring.Data.Entidades;
using Concepti.Factoring.Data.DAO_Classes;
using Concepti.Factoring.Data;
using System.Transactions;
using System.Data.Entity.Validation;

namespace Concepti.Factoring.Business.Classes
{
   public class ContratoBO:ContratoDAO
    {

       private Contrato _Contrato;

       private ContratoDAO _DAO = GenericSingleton<ContratoDAO>.GetInstance();

       #region DAO

       public void SalvarContrato(Contrato contrato)
       {
           try
           {
               if (contrato.COD_CONTRATO == null)
                   _DAO.Add(contrato);
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

       #region Construtores
       public ContratoBO()
       {

       }

       public ContratoBO(Contrato _contrato)
       {
           _Contrato = _contrato;
       }

       #endregion
       #region Métodos

       public  Contrato GetContrato(int codContrato)
       {
           return _DAO.Find(c => c.COD_CONTRATO == codContrato).FirstOrDefault<Contrato>();
       }

       public ArrayList gerarBoletos()
       {
           Boleto novoBoleto;
           BoletoDAO boletoDAO = new BoletoDAO();
           Periodicidade periodicidade = _Contrato.PERIODICIDADE_FK;

           ArrayList boletos = new ArrayList();

           decimal valorParcela = decimal.Parse(((_Contrato.VALOR + (_Contrato.VALOR * _Contrato.JUROS/100))/_Contrato.PERIODO).ToString());
           DateTime dataProx = DateTime.Now;
           
           for (int i = 0; i < _Contrato.PERIODO; i++)
           {
               novoBoleto = new Boleto();

               novoBoleto.COD_CONTRATO = _Contrato.COD_CONTRATO;
               novoBoleto.COD_SITUACAO_BOLETO = 1;
               switch (periodicidade.DESCRICAO)
               {
                   case "Diária":
                       if (i == 0)
                       {
                           novoBoleto.DATA_VENCIMENTO = verificaDataVencimento(DateTime.Now.AddDays(i + 2), _Contrato.CONTRATANTE_FK.DIA_FK.COD_DIA);
                           dataProx = novoBoleto.DATA_VENCIMENTO.AddDays(1);
                       }
                       else
                       {

                           novoBoleto.DATA_VENCIMENTO = verificaDataVencimento(dataProx, _Contrato.CONTRATANTE_FK.DIA_FK.COD_DIA);
                           dataProx = novoBoleto.DATA_VENCIMENTO.AddDays(1);
                       }
                       break;
                   case "Mensal":
                       if (i == 0)
                       {
                           novoBoleto.DATA_VENCIMENTO = verificaDataVencimento(DateTime.Now.AddMonths(i + 1), _Contrato.CONTRATANTE_FK.DIA_FK.COD_DIA);
                           dataProx = dataProx.AddMonths(2);
                       }
                       else
                       {
                           novoBoleto.DATA_VENCIMENTO = verificaDataVencimento(dataProx, _Contrato.CONTRATANTE_FK.DIA_FK.COD_DIA);
                           dataProx = dataProx.AddMonths(1);
                       }
                       break;

                   case "Quinzenal" :
                       if (i == 0)
                       {
                           novoBoleto.DATA_VENCIMENTO = verificaDataVencimento(DateTime.Now.AddDays(i + 15), _Contrato.CONTRATANTE_FK.DIA_FK.COD_DIA);
                           dataProx = dataProx.AddDays(30);
                       }
                       else
                       {
                           novoBoleto.DATA_VENCIMENTO = verificaDataVencimento(dataProx, _Contrato.CONTRATANTE_FK.DIA_FK.COD_DIA);
                           dataProx = dataProx.AddDays(15);
                       }
                       break;

                   case "Semanal":
                       if (i == 0)
                       {
                           novoBoleto.DATA_VENCIMENTO = verificaDataVencimento(DateTime.Now.AddDays(i + 7), _Contrato.CONTRATANTE_FK.DIA_FK.COD_DIA);
                           dataProx = dataProx.AddDays(14);
                       }
                       else
                       {
                           novoBoleto.DATA_VENCIMENTO = verificaDataVencimento(dataProx, _Contrato.CONTRATANTE_FK.DIA_FK.COD_DIA);
                           dataProx = dataProx.AddDays(7);
                       }
                       break;

                   case "Bimestral":
                       if (i == 0)
                       {
                           novoBoleto.DATA_VENCIMENTO = verificaDataVencimento(DateTime.Now.AddMonths(i + 2), _Contrato.CONTRATANTE_FK.DIA_FK.COD_DIA);
                           dataProx = dataProx.AddMonths(4);
                       }
                       else
                       {
                           novoBoleto.DATA_VENCIMENTO = verificaDataVencimento(dataProx, _Contrato.CONTRATANTE_FK.DIA_FK.COD_DIA);
                           dataProx = dataProx.AddMonths(2);
                       }

                       break;
                   case "Trimestral":
                       if (i == 0)
                       {
                           novoBoleto.DATA_VENCIMENTO = verificaDataVencimento(DateTime.Now.AddMonths(i + 3), _Contrato.CONTRATANTE_FK.DIA_FK.COD_DIA);
                           dataProx = dataProx.AddMonths(6);
                       }
                       else
                       {
                           novoBoleto.DATA_VENCIMENTO = verificaDataVencimento(dataProx, _Contrato.CONTRATANTE_FK.DIA_FK.COD_DIA);
                           dataProx = dataProx.AddMonths(3);
                       }
                       break;
                   case "Semestral":
                       if (i == 0)
                       {
                           novoBoleto.DATA_VENCIMENTO = verificaDataVencimento(DateTime.Now.AddMonths(i + 6), _Contrato.CONTRATANTE_FK.DIA_FK.COD_DIA);
                           dataProx = dataProx.AddMonths(12);

                       }
                       else
                       {
                           novoBoleto.DATA_VENCIMENTO = verificaDataVencimento(dataProx, _Contrato.CONTRATANTE_FK.DIA_FK.COD_DIA);
                           dataProx = dataProx.AddMonths(6);
                       }
                       break;
                   default:
                       novoBoleto.DATA_VENCIMENTO = verificaDataVencimento(DateTime.Now.AddDays(i + 1), _Contrato.CONTRATANTE_FK.DIA_FK.COD_DIA);
                       break;
             
               }
               //dataProx = novoBoleto.DATA_VENCIMENTO;
               novoBoleto.PARCELA = i + 1;
               novoBoleto.VALOR = valorParcela;

               boletoDAO.Add(novoBoleto);
               boletoDAO.SaveChanges();
               boletos.Add(novoBoleto);
               }
           return boletos;

       }

       public DataTable pegarBoletos()
       {
           DataTable dt = new DataTable();
           dt.Columns.Add("cod_boleto");
           dt.Columns.Add("area");
           dt.Columns.Add("vendedor");
           dt.Columns.Add("nome");
           dt.Columns.Add("num_parcela");
           dt.Columns.Add("total_parcela");
           dt.Columns.Add("vencimento");
           dt.Columns.Add("valor");
           dt.Columns.Add("data_pagamento");
          
            
           List<Boleto> arr = new List<Boleto>();

           BoletoDAO bDAO = new BoletoDAO();
           arr = bDAO.Find(b => b.COD_CONTRATO == _Contrato.COD_CONTRATO);
           for (int i = 0; i < arr.Count; i++)
           {
               DataRow row = dt.NewRow();
               row["cod_boleto"] = arr[i].COD_BOLETO.ToString().PadLeft(7,'0');
               row["area"] = _Contrato.CONTRATANTE_FK.AREA_FK.NOME.ToString();
               row["vendedor"] = _Contrato.ROTA_FK.VENDEDOR_FK.NOME.ToString();
               row["nome"] = _Contrato.CONTRATANTE_FK.COD_CONTRATANTE.ToString().PadLeft(4,'0') + " - " + _Contrato.CONTRATANTE_FK.NOME.ToString();
               row["num_parcela"] = arr[i].PARCELA.ToString().PadLeft(3,'0');
               row["total_parcela"] = _Contrato.PERIODO.ToString().PadLeft(3,'0');
               row["vencimento"] = string.Format("{0:dd/MM/yyyy}",arr[i].DATA_VENCIMENTO.ToShortDateString());
               row["valor"] = "R$ "+ arr[i].VALOR.ToString();
               row["data_pagamento"] = arr[i].DATA_PAGAMENTO.ToString() == DateTime.MinValue.ToString() ? "" : arr[i].DATA_PAGAMENTO.ToShortDateString();

               dt.Rows.Add(row);
         
           }

           return dt;
       }


       public DataTable pegarBoletosAbertos()
       {
           DataTable dt = new DataTable();
           dt.Columns.Add("cod_boleto");
           dt.Columns.Add("area");
           dt.Columns.Add("vendedor");
           dt.Columns.Add("nome");
           dt.Columns.Add("num_parcela");
           dt.Columns.Add("total_parcela");
           dt.Columns.Add("vencimento");
           dt.Columns.Add("valor");
           dt.Columns.Add("data_pagamento");


           List<Boleto> arr = new List<Boleto>();

           BoletoDAO bDAO = new BoletoDAO();
           arr = bDAO.Find(b => b.COD_CONTRATO == _Contrato.COD_CONTRATO && b.COD_SITUACAO_BOLETO==1);
           for (int i = 0; i < arr.Count; i++)
           {
               DataRow row = dt.NewRow();
               row["cod_boleto"] = arr[i].COD_BOLETO.ToString().PadLeft(7, '0');
               row["area"] = _Contrato.CONTRATANTE_FK.AREA_FK.NOME.ToString();
               row["vendedor"] = _Contrato.ROTA_FK.VENDEDOR_FK.NOME.ToString();
               row["nome"] = _Contrato.CONTRATANTE_FK.COD_CONTRATANTE.ToString().PadLeft(4, '0') + " - " + _Contrato.CONTRATANTE_FK.NOME.ToString();
               row["num_parcela"] = arr[i].PARCELA.ToString().PadLeft(3, '0');
               row["total_parcela"] = _Contrato.PERIODO.ToString().PadLeft(3, '0');
               row["vencimento"] = string.Format("{0:dd/MM/yyyy}", arr[i].DATA_VENCIMENTO.ToShortDateString());
               row["valor"] = "R$ " + arr[i].VALOR.ToString();
               row["data_pagamento"] = arr[i].DATA_PAGAMENTO.ToString() == DateTime.MinValue.ToString() ? "" : arr[i].DATA_PAGAMENTO.ToShortDateString();

               dt.Rows.Add(row);

           }

           return dt;
       }


       public List<Contrato> ContratosDoContrante(int codContratante)
       {
           return Find(c => c.COD_CONTRATANTE == codContratante).ToList<Contrato>(); 

       }

       public List<Contrato> ContratosAtivosDoContrante(int codContratante)
       {
           return Find(c => c.COD_CONTRATANTE == codContratante && c.ATIVO == true).ToList<Contrato>();

       }

       public List<Contrato> ContratosAbertosDoContrante(int codContratante)
       {
           Contexto context = new Contexto();
           var query = from contrato in context.Contratos
                       join boleto in context.Boletos
                       on contrato.COD_CONTRATO equals boleto.COD_CONTRATO
                       where contrato.COD_CONTRATANTE == codContratante && boleto.COD_SITUACAO_BOLETO == 1
                       select contrato;
           return query.Distinct<Contrato>().ToList<Contrato>();

       }


       public bool BaixarBoletosAberto(int codContrato)
       {
           return new BoletoBO().BaixarBoletosContrato(codContrato);
       }

       public bool PodeCancelar()
       {
           bool pode = false;
           pode = new BoletoBO().BoletosBaixados(_Contrato.COD_CONTRATO).Count == 0 && _Contrato.ATIVO == true;

           return pode;
       }


       public DataTable pegarDadosContrato()
       {
           DataTable dt = new DataTable();
           dt.Columns.Add("codigo");
           dt.Columns.Add("valor");
           dt.Columns.Add("juros");
           dt.Columns.Add("parcelas");
           dt.Columns.Add("data");
           dt.Columns.Add("cliente");
           dt.Columns.Add("vencimento");
           dt.Columns.Add("cobrador");


          

               DataRow row = dt.NewRow();
               row["codigo"] = this._Contrato.COD_CONTRATO.ToString();
               row["valor"] = this._Contrato.VALOR.ToString();
               row["juros"] = this._Contrato.JUROS.ToString();
               row["parcelas"] = this._Contrato.PERIODO.ToString();
               row["data"] = this._Contrato.DATA_ABERTURA.ToShortDateString();
               row["cliente"] = this._Contrato.CONTRATANTE_FK.NOME.ToUpper();
               row["vencimento"] = this._Contrato.PERIODICIDADE_FK.DESCRICAO.ToUpper();
               row["cobrador"] = this._Contrato.ROTA_FK.VENDEDOR_FK.NOME.ToUpper();
               
               dt.Rows.Add(row);

          

           return dt;
       }

       public DataTable pegarHistoricoContratos(string nomeCliente)
       {
           Contexto context = new Contexto();

           DataTable dt = new DataTable();
           dt.Columns.Add("cod_contrato");
           dt.Columns.Add("nome");
           dt.Columns.Add("valor");
           dt.Columns.Add("data");
           dt.Columns.Add("num_parcelas");
           dt.Columns.Add("num_parcelas_pagas");

          List<Object> arr = new List<object>();

           var consulta = from c in context.Contratos
                          where c.CONTRATANTE_FK.NOME.Contains(nomeCliente)
                          join b in context.Boletos
                          on c.COD_CONTRATO equals b.COD_CONTRATO
                          group b by new 
                          {b.COD_CONTRATO,
                          b.CONTRATO_FK.VALOR,
                          b.CONTRATO_FK.DATA_ABERTURA,
                          b.CONTRATO_FK.CONTRATANTE_FK.NOME,
                          b.CONTRATO_FK.PERIODO,
                          }into g  
                          select new {g.Key.COD_CONTRATO ,g.Key.NOME,g.Key.VALOR,g.Key.DATA_ABERTURA,g.Key.PERIODO, parcelas_pagas = g.Count(b=>b.COD_SITUACAO_BOLETO==2)} ;
           arr = consulta.ToList<object>();

           foreach (var x in consulta)
           {
               DataRow row = dt.NewRow();
               row["cod_contrato"] = x.COD_CONTRATO;
               row["nome"] = x.NOME;
               row["valor"] = x.VALOR;
               row["data"] = x.DATA_ABERTURA.ToShortDateString();
               row["num_parcelas"] = x.PERIODO.ToString();
               row["num_parcelas_pagas"] = x.parcelas_pagas;
               dt.Rows.Add(row);
           }

           return dt;
       }

       public DateTime verificaDataVencimento(DateTime data, int diaDaSemana)
       {
           DateTime dataRetorno = data;

           if (!diaDaSemana.Equals("-1"))
           {
               if (data.DayOfWeek == 0 || data.DayOfWeek == (DayOfWeek)diaDaSemana)
               {
                   dataRetorno = data.AddDays(1);
                  return verificaDataVencimento(dataRetorno, diaDaSemana);
               }
               else if (EhFeriado(data))
               {
                   dataRetorno = data.AddDays(1);
                  return verificaDataVencimento(dataRetorno, diaDaSemana);
               }
               else
                   return dataRetorno;
           }
           else
           {

               if (data.DayOfWeek == 0 )
               {
                   dataRetorno = data.AddDays(1);
                 return  verificaDataVencimento(dataRetorno, diaDaSemana);
               }
               else if (EhFeriado(data))
               {
                    dataRetorno = data.AddDays(1);
                  return verificaDataVencimento(dataRetorno, diaDaSemana);
               }
               else
                   return dataRetorno;
           }

          // return dataRetorno;
       }

       public bool EhFeriado(DateTime data)
       {
           string parametro = data.Day.ToString().PadLeft(2,'0') + "/" + data.Month.ToString().PadLeft(2,'0');

           List<Feriado>  feriado = new FeriadoDAO().Find(f => f.DIAMES == parametro).ToList();

           return feriado.Count>0;
       }

       public List<Vendedor> buscaVendedoresComRotaArea(int codArea)
       {
           Contexto context = new Contexto();


           var consulta = from a in context.Vendedores
                          where (from r in context.Rotas where r.CONCLUIDA == false select r.COD_VENDEDOR).Contains(a.COD_VENDEDOR) && a.COD_AREA == codArea
                          select a;

           //context = null;
           return consulta.ToList<Vendedor>();

       }


       public void CancelarContrato()
       {
           bool success;
          
               if (PodeCancelar())
               {
                   using (TransactionScope scope = new TransactionScope())
                   {
                       try
                       {
                           new BoletoBO().CancelarBoletosContrato(_Contrato.COD_CONTRATO);
                           Contrato contrt = GetContrato(_Contrato.COD_CONTRATO);
                           contrt.ATIVO = false;
                           SalvarContrato(contrt);
                           success = true;       

                       }catch
                       {
                           success = false;
                           scope.Dispose();
                           throw new Exception("Ocorreu um erro inesperado. O contrato não foi cancelado.");
                       }

                       if (success) scope.Complete();


                   }
               }
           

       }
  

       #endregion

    }
}
