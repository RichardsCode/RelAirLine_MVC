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
    public class AccountController : Controller
    {
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
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB; database=AirLineDb; Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public ActionResult Verify(CustomerModel cst)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Customer where EmailAddress='" + cst.EmailAddress + "' and Password='" + cst.Password + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                con.Close();
                
                return View("SignIn");
            }


        }
    }
}