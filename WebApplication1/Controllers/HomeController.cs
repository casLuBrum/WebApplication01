using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        FichaService fichaService = new FichaService();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("kkk")]
        public ActionResult Fichas()
        {
            List<Ficha> fichas = fichaService.ObterTodasFichas();
            return View(fichas);
        }
    }
}