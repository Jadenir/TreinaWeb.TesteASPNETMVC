using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreinaWeb.TesteASPNETMVC.Web.Models;

namespace TreinaWeb.TesteASPNETMVC.Web.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            ViewBag.PessoaInformada = pessoa.Nome;
            return View("Saudacao", pessoa);
        }
    }
}