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
        public ActionResult Index()
        {
            //ViewBag.Title = "Home Page";

            //return View();

            return View(db.Articles.ToList().OrderByDescending(i => i.ID));
        }
    }
}
