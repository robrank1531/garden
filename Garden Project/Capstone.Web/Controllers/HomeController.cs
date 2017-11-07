using Capstone.Web.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Web.Models;
using System.Globalization;

namespace Capstone.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IParkWeatherDal applicationDal;

        public HomeController(IParkWeatherDal applicationDal)
        {
            this.applicationDal = applicationDal;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(string id)
        {
            return View();
        }
    }
}