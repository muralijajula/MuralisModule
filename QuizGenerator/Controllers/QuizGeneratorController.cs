﻿using System.Web.Mvc;

namespace QuizGenerator.Controllers
{
    public class QuizGeneratorController : Controller
    {
        // GET: QuizGenerator
        public ActionResult Index()
        {
            return View();
        }

        // GET: QuizGenerator/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuizGenerator/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuizGenerator/Create
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

        // GET: QuizGenerator/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuizGenerator/Edit/5
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

        // GET: QuizGenerator/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuizGenerator/Delete/5
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
