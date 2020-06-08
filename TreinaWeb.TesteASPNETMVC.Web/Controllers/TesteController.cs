using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.Expressions;
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
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Exclude = "Ativo")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                return View("Saudacao", pessoa);
            }
            else
            {
                return View(pessoa);
            }
        }
    }
}