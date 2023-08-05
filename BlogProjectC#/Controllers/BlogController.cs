using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using BlogProjectC_.Controllers;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;
using BlogProjectC_.Controllers;
using BlogProjectC_.Models;

namespace BlogProjectC_.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog

        BlogDbEntities BlogDbEntities = new BlogDbEntities();
        RegistrationDbEntities reg = new RegistrationDbEntities();

        public ActionResult Index()
        {

            var blogDetails = BlogDbEntities.BlogTables.ToList().OrderByDescending(x => x.BId);
            return View(blogDetails);

        }

        public ActionResult Uploadblog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Uploadblog(BlogTable bg)
        {

            BlogDbEntities.BlogTables.Add(bg);
            BlogDbEntities.SaveChanges();
            ViewBag.message = "Blog Details Are Saved Successfully....!";

            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(RegistrationTable rg)
        {
            reg.RegistrationTables.Add(rg);
            reg.SaveChanges();

            ViewBag.Message = rg.Uname + " register succesfully done...";
            return View();
        }

        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult login(LoginModel lm)
        {
            RegistrationTable rg=new RegistrationTable();
            var user=reg.RegistrationTables.Where(x=>x.Uname == lm.UserName && x.Upass == lm.UserPass).Count();

            if (user>0)
            {
                ViewBag.Message = rg.Uname +" Log in succesfully done...";
                return View("Uploadblog");
            }
            else
            {
                ViewBag.Message =" Log in details are wrong...";
                return View();
            }
        }


        public ActionResult Code()
        {
            var codeArticle = BlogDbEntities.BlogTables.Where(x => x.BCategory == "Code").OrderByDescending(x => x.BId);
            return View(codeArticle);
        }

        public ActionResult DataStructure()
        {
            var dataStructureArticle = BlogDbEntities.BlogTables.Where(x => x.BCategory == "DataStructure").OrderByDescending(x => x.BId);
            return View(dataStructureArticle);
        }

        public ActionResult Algorithm()
        {
            var algorithmArticle = BlogDbEntities.BlogTables.Where(x => x.BCategory == "Algorithm").OrderByDescending(x => x.BId);
            return View(algorithmArticle);
        }


    }
}