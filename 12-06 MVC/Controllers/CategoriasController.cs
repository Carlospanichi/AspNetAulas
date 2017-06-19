using Aula_12_06_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula_12_06_MVC.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>();
            categorias.Add(new Categoria() { Nome = "Carros", Descricao ="Carros velozes" });
            categorias.Add(new Categoria() { Nome = "Motos", Descricao = "Carros velozes" });
            categorias.Add(new Categoria() { Nome = "Barcos", Descricao = "Carros velozes" });
            categorias.Add(new Categoria() { Nome = "Aviões", Descricao = "Carros velozes" });
            categorias.Add(new Categoria() { Nome = "Caminhões" });
            /*categorias.Add("Carros");
            categorias.Add("Motos");
            categorias.Add("Barcos");
            categorias.Add("Aviões");
            categorias.Add("Caminhões");*/

            ViewBag.ListaCategorias = categorias;
            return View();
        }
        //GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            return View(categoria);
        }
    }
}