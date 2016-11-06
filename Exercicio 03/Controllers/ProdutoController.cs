using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercicio_03.Models;

namespace Exercicio_03.Controllers
{
    public class ProdutoController : Controller
    {
        private static List<Produto> _lista = new List<Produto>();

        // GET: Produto
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Produto produto)
        {
            _lista.Add(produto);

            ViewBag.prod = produto;
            TempData["msg"] = "Produto cadastrado!";

            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_lista);
        }
        
    }
}