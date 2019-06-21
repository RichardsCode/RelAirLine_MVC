using RelAirLine_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.CustomerProccessor;
using DataLibrary.DataAccess;
using System.Data.SqlClient;
using DataLibrary.BusinessLogic;

namespace RelAirLine_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SignUp()
        {
            ViewBag.Message = "New Customer Sign Up page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                CreateCustomer(model.FirstName,
                               model.MiddleName,
                               model.LastName,
                               model.Suffix,
                               model.BirthDate,
                               model.Gender,
                               model.PhoneNumber,
                               model.AddressLine1,
                               model.AdressLine2,
                               model.ZipCode,
                               model.City,
                               model.State,
                               model.EmailAddress,
                               model.Password);

                return RedirectToAction("SignIn");
            }

            return View();
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            ViewBag.Message = "Sign In";
            return View();
        }

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;


        void connectionString()
        {
            con.ConnectionString = "data sourrce=MSSQLLocalDB; database=AirLineDb; security = SSPI;";
        }

        public ActionResult Verify(CustomerModel cst)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Customer where username='"+cst.EmailAddress+"' and password='"+cst.Password+ "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("Contact");
            }
            else
            {
                con.Close();
                return View("Index");
            }
            
            
        }
    }
}

   
