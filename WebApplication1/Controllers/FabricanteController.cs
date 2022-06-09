using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FabricanteController : Controller
    {
       // private EFContext context = new EFContext();
        private static IList<Fabricante> fabri = new List<Fabricante>()
        {
            new Fabricante() {FabricanteId = 1, Nome = "Microsoft"},
            new Fabricante() {FabricanteId = 2, Nome = "Lo"}
        };
        // GET: Fabricante
        public ActionResult Index()
        {
            //  return View(context.Fabricantes.OrderBy(c=> c.Nome));
            return View(fabri);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Fabricante fab)
        {
            fab.FabricanteId = fabri.Select(c => c.FabricanteId).Max() + 1;
            fabri.Add(fab);
            return RedirectToAction("Index");
        }

        /*
         com banco de dados
        public ActionResult Edit(long? id){
            if(id==null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);//pagina não encontrada
        }
            Fabricante fab = context.Fabricante.Find(id);
            if(fab==null)
        {
            return HttpostNotFound();
        }

     }

        public ActionResult Edit()



        /*
    }
}