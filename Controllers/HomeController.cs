using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cap03N.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PaginaNova()
        {
            // Informações que vão personalizar a View (ex. BD)

            ViewBag.Codigo = "1";
            ViewBag.Nome = "Joao";

            ViewData["Endereco"] = "R. Alguma coisa";
            ViewData["Estado"] = "Sei Lá";
            
            return View();
        }

        public string Mensagem()
        {
            return "Bem Vindo";
        }

        public string Integracao()
        {
            return "<Nome>Joao da Silva</Nome>";
        }
    }
}


