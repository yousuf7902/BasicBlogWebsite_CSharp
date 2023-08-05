using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogProjectC_.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace BlogProjectC_.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RegistrationClass rgc) {
            string sqlquery = "insert into [dbo].[RegistrationTable] (Uname,Uemail,Upass,Ugender) values(@Uname, @Uemail, @Upass, @Ugender)";
            SqlCommand sqlcomm= new SqlCommand(sqlquery);
            sqlcomm.Parameters.AddWithValue("@Uname", rgc.Uname);
            sqlcomm.Parameters.AddWithValue("@Uemail", rgc.Uemail);
            sqlcomm.Parameters.AddWithValue("@Upass", rgc.Upass);
            sqlcomm.Parameters.AddWithValue("@Ugender", rgc.Ugender);

        

            ViewData["Message"] = "User record" + rgc.Uname + " successfully added...";

            return View();

        }

        
    }
}