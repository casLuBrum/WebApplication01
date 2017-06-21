using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.WebApplication1.Models;

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

        public ActionResult Fichas()
        {
            List<Ficha> fichas = fichaService.ObterTodasFichas();
            return View(fichas);
        }

        [HttpGet]
        public ActionResult DetalheFicha (int id)
        {
            Ficha ficha = fichaService.ObterFicha(id);
            return View(ficha);
        }

        [HttpGet]
        public ActionResult IncluirFicha ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirFicha (Ficha ficha)
        {
            fichaService.incluirFicha(ficha);
            return View("DetalheFicha", ficha);
        }
    }
}