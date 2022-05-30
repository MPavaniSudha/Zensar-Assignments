using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Assignment1.Models;

namespace MVC_Assignment1.Controllers
{
    public class CustomerController : Controller
    {
        NorthwindEntities nw = new NorthwindEntities();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        //1.Getting all customers residing in germany
        public ActionResult Get_Cust_Res_Germany()
        {
            List<string> Cnam = (from cus in nw.Customers
                                 where cus.Country == "Germany"
                                 select cus.ContactName).ToList();
            return View(Cnam);
        }
        //2.Getting Customer details whose customer id is 10248
        public ActionResult Get_Customer_Details()
        {
            List<Customer> CUST = (from cus in nw.Customers
                                   join or in nw.Orders
                                   on cus.CustomerID equals or.CustomerID
                                   where or.OrderID == 10248
                                   select cus).ToList();
            return View(CUST);
        }
    }
}