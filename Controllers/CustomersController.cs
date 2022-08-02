using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customersList = new List<Customer>
            {
                new Customer() { Name = "John Smith" , Id = 1},
                new Customer() { Name = "Mary Williams", Id = 2 }
            };

            var customers = new CustomerViewModel()
            {
                Customers = customersList
            };
            return View(customers);

        }

        public ActionResult Details(int id)
        {
            if (id == 1)
            {
                return View(new Customer() { Name = "John Smith"});
            }
            else if (id == 2)
            {
                return View(new Customer() { Name = "Mary Williams" });
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}