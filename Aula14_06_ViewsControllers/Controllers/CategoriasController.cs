using System.Collections.Generic;
using System.Web.Mvc;
using Aula14_06_ViewsControllers.Models;
using System.Net;
using System;

namespace Aula14_06_ViewsControllers.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias (GET = Carregamento da página)
        public ActionResult Index()
        {
            List<Categoria> categoria = new List<Categoria>();
            //Retornar lista de objetos cadastrados
            return View();
        }
        //GET
        public ActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        //public ActionResult Create(Categoria categoria, FormCollection campos) Recuperar Campo a Campo sem ter model
        public ActionResult Create(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                // insert
            }
            return View(categoria);
        }
        //GET 
        public ActionResult Edit(int? id)
        {
            //verificar se veio o ID
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //pesquisa na fonte de dados o objeto a editar
            //Categoria categoria = null;
            Categoria categoria = new Categoria()
            { CategoriaID = id.Value, Nome = "Carros", Descricao = "Super Carros", Ativo = true };
            if (categoria == null)
            {
                //ERRO - 404
                return HttpNotFound();
            }
            return View();
        }

        //POST
        [HttpPost]
        public ActionResult Edit(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //update na fonte de dados
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return View(categoria);
        }

        //Get
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = new Categoria()
            {
                CategoriaID = id.Value,
                Nome = "Carros",
                Descricao = "Super Carros",
                Ativo = true
            };

            if (categoria == null)
            {
                //ERRO - 404
                return HttpNotFound();
            }
            return View(categoria);

        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmar (int id)
        {
            TempData["Mensagem"] = "Categoria Excluida!!";
            return RedirectToAction("Index");
        }
    }

}