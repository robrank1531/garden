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

        private readonly IPlantsSqlDal plantDal;

        public HomeController(IPlantsSqlDal plantDal)
        {
            this.plantDal = plantDal;
        }

        public ActionResult Index()
        {
            List<Plants> plants = plantDal.GetPlants();
            return View(plants);
        }

        public ActionResult Detail(string id)
        {
            Plants p = new Plants();
            //p = plantDal
            return View();
        }
    }
}