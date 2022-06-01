using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoriasController : Controller
    {
        private static IList<Categoria> cat = new List<Categoria>()
        {
            new Categoria() {CategoriaId = 1, Nome ="notebooks"},
            new Categoria() {CategoriaId = 2, Nome = "monitores"},
            new Categoria() {CategoriaId = 3, Nome=  "desktops"},
        };
        // GET: Categorias
        public ActionResult Index()
        {
            return View(cat);
        }
    }
}