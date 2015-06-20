using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductErpSystem.Areas.Customer.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Customer/Dashboard
        public ActionResult Index()
        {
            return View();
        }

    }
}