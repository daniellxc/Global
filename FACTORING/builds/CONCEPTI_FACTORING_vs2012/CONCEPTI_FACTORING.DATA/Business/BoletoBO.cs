using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Transactions;
using Concepti.Factoring.Data.DAO_Classes;
using Concepti.Factoring.Data.Entidades;
using Concepti.Factoring.Data;
using System.Data.Entity.Validation;



namespace Concepti.Factoring.Business.Classes
{
    public class BoletoBO:BoletoDAO
    {

        private BoletoDAO _DAO = GenericSingleton<BoletoDAO>.GetInstance();

        private Boleto _boleto;

        #region DAO

        public void SalvarBoleto(Boleto _boleto)
        {
            try
            {
                if (_boleto.COD_BOLETO == 0)
                    _DAO.Add(_boleto);
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

        public void ExcluirBoleto(Boleto _boleto)
        {
            {
                try
                {  
                    _DAO.Delete(_boleto);
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
        }

        #endregion

        public BoletoBO()
        {
        }

        public BoletoBO(Boleto boleto)
        {
            _boleto = boleto;
        }


        #region Métodos

        public void BaixarBoleto()
        {
            bool sucesso = false;
            int cod_rota = 0;

            if (!this._boleto.COD_SITUACAO_BOLETO.Equals(2))
            {

                 BoletoDAO _boletoDAO = new BoletoDAO();
                 Movimento movimento = new Movimento();
                 MovimentoDAO movimentoDAO = new MovimentoDAO();
                 MovimentoRotaDAO mRotaDAO = new MovimentoRotaDAO();
                 MovimentoRota movimentoRota = new MovimentoRota();

                 using (TransactionScope scope = new TransactionScope())
                 {
                     try
                     {
                          cod_rota = new VendedorBO(_boleto.CONTRATO_FK.ROTA_FK.VENDEDOR_FK).buscarRotaAberta().COD_ROTA;
                        
                             
                         Boleto _boletoNovo = _boletoDAO.Find(b => b.COD_BOLETO == _boleto.COD_BOLETO).First<Boleto>();
                         _boletoNovo.COD_SITUACAO_BOLETO = 2;
                         _boletoNovo.DATA_PAGAMENTO = DateTime.Now;
                         _boletoDAO.SaveChanges();

                         movimento.COD_TIPO_MOVIMENTO = 3;
                         movimento.MOMENTO = _boletoNovo.DATA_PAGAMENTO;
                         movimento.VALOR = _boletoNovo.VALOR;

                         movimentoDAO.Add(movimento);
                         movimentoDAO.SaveChanges();

                         movimentoRota.COD_MOVIMENTO = movimento.COD_MOVIMENTO;
                         movimentoRota.COD_ROTA = cod_rota;

                         mRotaDAO.Add(movimentoRota);
                         mRotaDAO.SaveChanges();
                         sucesso = true;
                     }
                     catch
                     {
                         if(cod_rota == 0)
                             throw new Exception("Não há rota aberta para o vendedor: " + _boleto.CONTRATO_FK.ROTA_FK.VENDEDOR_FK.NOME); 
                         else
                         throw new Exception("Não há rota aberta para o vendedor: " + _boleto.CONTRATO_FK.ROTA_FK.VENDEDOR_FK.NOME); 

                     }

                     if (sucesso)
                         scope.Complete();
                 }

            }
            else
            {
                throw new Exception("Este boleto não pode ser baixado.");
            }
        }

       

        public List<Boleto> BoletosContrato(int codContrato)
        {
            return _DAO.Find(b => b.COD_CONTRATO == codContrato).ToList<Boleto>(); 
        }

        public List<Boleto> BoletosBaixados(int codContrato)
        {
            return Find(b => b.COD_SITUACAO_BOLETO == 2 && b.COD_CONTRATO == codContrato).ToList<Boleto>();

        }

        public List<Boleto> BoletosNaoBaixados(int codContrato)
        {
            return Find(b => b.COD_SITUACAO_BOLETO == 1 && b.COD_CONTRATO == codContrato).ToList<Boleto>();

        }

        public void CancelarBoletosContrato(int codContrato)
        {
            foreach (Boleto boleto in BoletosContrato(codContrato))
                MudarSituacao(boleto, 3);

        }

        internal bool BaixarBoletosContrato(int codContrato)
        {
            try
            {
                foreach (Boleto boleto in BoletosNaoBaixados(codContrato))
                {
                    this._boleto = boleto;
                    BaixarBoleto();
                }

                return true;
            }
            catch
            {
                
                return false;
                throw;
            }
        }

        private void MudarSituacao(Boleto boleto,int codSituacao)
        {
            boleto.COD_SITUACAO_BOLETO = codSituacao;
            SalvarBoleto(boleto);

        }

     
        #endregion

    }
}
