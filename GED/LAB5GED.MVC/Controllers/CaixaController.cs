using LAB5GED.DOMAIN.DAO.Business;
using LAB5GED.DOMAIN.Entidades;
using LAB5GED.MVC.Acessorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB5GED.MVC.Controllers
{
    public class CaixaController : Controller
    {
        //
        // GET: /Caixa/

        private CaixaBO _DAO = new CaixaBO();

        public ActionResult Index()
        {
            MetodosUtilidadeGeral.LimparSessaoEdicao(Session); 
            return View(_DAO.GetAll());
        }

        public ActionResult Cadastrar(Caixa _caixa)
        {
            return View(_caixa);
        }

        public ActionResult Editar(int _registroCaixa)
        {
            Session["id"] = _registroCaixa;
            return View("Cadastrar",_DAO.GetByRegistro(_registroCaixa));
        }

        public ActionResult CadastrarCaixa(Caixa _novaCaixa)
        {
            if (!ModelState.IsValid)
                return View("Cadastrar", _novaCaixa);
            {
                try
                {

                    if (Session["id"] != null) _novaCaixa.Registro = int.Parse(Session["id"].ToString());
                    _DAO.SalvarCaixa(_novaCaixa);
                    return RedirectToAction("Index");

                }
                catch (Exception ex)
                {
                    MetodosUtilidadeGeral.MensagemDeErro(ex.Message, Response);
                    return View("Cadastrar", _novaCaixa);

                }
            }

        }
        [PermissaoFiltro("ArmazenarDocumento")]
        public ActionResult Armazenar(int _registroDocumento)
        {
            return View(new DocumentoBO().GetByRegistro(_registroDocumento));

        }

        

    }
}
