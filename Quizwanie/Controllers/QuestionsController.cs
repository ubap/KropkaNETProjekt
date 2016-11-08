using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Quizwanie.Models;

namespace Quizwanie.Controllers
{
    [Authorize]
    public class QuestionsController : Controller
    {
        private QuestionDBContext db = new QuestionDBContext();

        // GET: Questions
        public ActionResult Create()
        {
            return View();
        }

        // POST: Questions/Index
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Content,CorrectAnswer,WrongAnswer1,WrongAnswer2,WrongAnswer3")] Question question)
        {
            if (ModelState.IsValid)
            {
                db.Questions.Add(question);
                db.SaveChanges();
                return RedirectToAction("../");
            }

            return View(question);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
