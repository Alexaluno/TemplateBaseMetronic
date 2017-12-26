using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplateBaseV01.Models;

namespace TemplateBaseV01.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            var lista = new List<Pagamento>();
            var pagemento1 = new Pagamento("visa", 10, 1);
                lista.Add(pagemento1);

            var pagemento2 = new Pagamento("visa", 13, 1);
                lista.Add(pagemento2);

            var pagemento3 = new Pagamento("visa", 12, 1);
                lista.Add(pagemento3);

            var pagemento4 = new Pagamento("visa", 15, 1);
                lista.Add(pagemento4);

            return View(lista);
        }

        // GET: Default/Details/5
        public ActionResult Details()
        {
            var lista = new List<Pagamento>();
            var pagemento1 = new Pagamento("visa", 10, 1);
            lista.Add(pagemento1);

            var pagemento2 = new Pagamento("visa", 13, 2);
            lista.Add(pagemento2);

            var pagemento3 = new Pagamento("visa", 12, 3);
            lista.Add(pagemento3);

            var pagemento4 = new Pagamento("visa", 15, 4);
            lista.Add(pagemento4);

            var retorno = lista.Where(c => c.quantidadeParcelas == 1).FirstOrDefault();

            return View(retorno);
        }

        // GET: Default/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Default/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Default/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Default/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
