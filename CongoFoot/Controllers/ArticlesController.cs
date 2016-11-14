using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CongoFoot.DAL;
using CongoFoot.Models;
using PagedList;

namespace CongoFoot.Controllers
{
    public class ArticlesController : Controller
    {
        private MyDbContext db = new MyDbContext();

        // GET: Articles
        public ActionResult Index()
        {
            //ViewBag.Title = "Home Page";

            return View(db.Articles.ToList().OrderByDescending(i => i.DatePublication).Take(24));
        }

        // GET: Articles
        public ActionResult Administration()
        {
            return View(db.Articles.ToList().OrderByDescending(i => i.DatePublication));
        }

        // GET: Articles RDC
        public ActionResult RDC(string currentFilter, string searchString, int? page)
        {
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var articles = db.Articles.Where(i => i.Categorie.ToString() == "RDC");

            if (!String.IsNullOrEmpty(searchString))
            {
                articles = articles.Where(s => s.Titre.ToUpper().Contains(searchString.ToUpper())
                ||
                s.Contenu.ToUpper().Contains(searchString.ToUpper()));
            }

            articles = articles.OrderByDescending(a => a.DatePublication);

            int pageSize = 9;
            int pageNumber = (page ?? 1);
            return View(articles.ToPagedList(pageNumber, pageSize));
        }

        // GET: Articles Monde
        public ActionResult Monde(string currentFilter, string searchString, int? page)
        {
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var articles = db.Articles.Where(i => i.Categorie.ToString() == "Monde");

            if (!String.IsNullOrEmpty(searchString))
            {
                articles = articles.Where(s => s.Titre.ToUpper().Contains(searchString.ToUpper())
                ||
                s.Contenu.ToUpper().Contains(searchString.ToUpper()));
            }

            articles = articles.OrderByDescending(a => a.DatePublication);

            int pageSize = 9;
            int pageNumber = (page ?? 1);
            return View(articles.ToPagedList(pageNumber, pageSize));
        }

        // GET: Articles Linafoot
        public ActionResult Linafoot(string currentFilter, string searchString, int? page)
        {
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var articles = db.Articles.Where(i => i.Categorie.ToString() == "Linafoot");

            if (!String.IsNullOrEmpty(searchString))
            {
                articles = articles.Where(s => s.Titre.ToUpper().Contains(searchString.ToUpper())
                ||
                s.Contenu.ToUpper().Contains(searchString.ToUpper()));
            }

            articles = articles.OrderByDescending(a => a.DatePublication);

            int pageSize = 9;
            int pageNumber = (page ?? 1);
            return View(articles.ToPagedList(pageNumber, pageSize));
        }

        // GET: Articles C1
        public ActionResult C1(string currentFilter, string searchString, int? page)
        {
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var articles = db.Articles.Where(i => i.Categorie.ToString() == "C1");

            if (!String.IsNullOrEmpty(searchString))
            {
                articles = articles.Where(s => s.Titre.ToUpper().Contains(searchString.ToUpper())
                ||
                s.Contenu.ToUpper().Contains(searchString.ToUpper()));
            }

            articles = articles.OrderByDescending(a => a.DatePublication);

            int pageSize = 9;
            int pageNumber = (page ?? 1);
            return View(articles.ToPagedList(pageNumber, pageSize));
        }

        // GET: Articles C2
        public ActionResult C2(string currentFilter, string searchString, int? page)
        {
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var articles = db.Articles.Where(i => i.Categorie.ToString() == "C2");

            if (!String.IsNullOrEmpty(searchString))
            {
                articles = articles.Where(s => s.Titre.ToUpper().Contains(searchString.ToUpper())
                ||
                s.Contenu.ToUpper().Contains(searchString.ToUpper()));
            }

            articles = articles.OrderByDescending(a => a.DatePublication);

            int pageSize = 9;
            int pageNumber = (page ?? 1);
            return View(articles.ToPagedList(pageNumber, pageSize));
        }

        // GET: Articles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        // GET: Articles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Titre,Auteur,DatePublication,DateModification,UrlImage,Contenu,Categorie")] Article article)
        {
            article.DatePublication = DateTime.Now;
            article.DateModification = DateTime.Now;
            if (ModelState.IsValid)
            {
                db.Articles.Add(article);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(article);
        }

        // GET: Articles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Titre,Auteur,DatePublication,DateModification,UrlImage,Contenu,Categorie")] Article article)
        {
            if(article.DatePublication == null)
            {
                article.DatePublication = DateTime.Now;
            }
            article.DateModification = DateTime.Now;
            if (ModelState.IsValid)
            {
                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(article);
        }

        // GET: Articles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Article article = db.Articles.Find(id);
            db.Articles.Remove(article);
            db.SaveChanges();
            return RedirectToAction("Index");
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
