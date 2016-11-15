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

namespace CongoFoot.Controllers
{
    public class HomeController : Controller
    {
        private MyDbContext db = new MyDbContext();

        public List<Article> GetAllArticles()
        {
            return (db.Articles.ToList().OrderByDescending(i => i.DatePublication).Take(6).ToList());
        }
        public ActionResult Index()
        {
            //ViewBag.Title = "Home Page";

            //return View();

            ViewBag.AllArticles = GetAllArticles();

            return View(db.Articles.ToList().OrderByDescending(i => i.DatePublication).Take(18));
        }
    }
}
