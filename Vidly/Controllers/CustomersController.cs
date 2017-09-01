using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        // GET: Customer Detail
        public ActionResult Detail(int Id)
        {
            var customer = GetCustomers().Find(c => c.Id == Id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{Id = 1, Name="Jane Doe"},
                new Customer{Id = 2, Name="John Q. Public"},
            };
        }
    }
}