using EcoKh.Business;
using EcoKh.DAL.Entity;
using EcoKh.DAL;
using EcoKh.Models;
using EcoKh.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcoKh.Controllers
{
    public class HomeController : Controller
    {
        pzf_helper pzfhelp = new pzf_helper(new Repository());
        ZnachenieHelper znach = new ZnachenieHelper(new Repository());
        TypeTerritorHelper typreter = new TypeTerritorHelper(new Repository());
        TypePZF_Helper typepzf = new TypePZF_Helper(new Repository());

        //public ActionResult Index(int pid)
        //{
        //    var vm = new PZFViewModel() { fond = pzfhelp.GetPZFs(), territor = typreter.GetTypeTer(pid), type = typepzf.GetTypePZF(pid), znachenie = znach.GetZnachenie(pid) };
        //    return View(vm);
        //}

        public ActionResult Index()
        {
            var model = new PZFViewModel
            {
                fond = pzfhelp.GetPZFs(),
            };
            return View(model);
        }

        public JsonResult GetData()
        {

            var vm = new PZFViewModel
            {
                fond = pzfhelp.GetPZFs(),
            };



            return Json(vm, JsonRequestBehavior.AllowGet);
        }



        //public JsonResult GetData()
        //{
        //    // создадим список данных
        //    List<Station> stations = new List<Station>();
        //    stations.Add(new Station()
        //    {
        //        Id = 1,
        //        PlaceName = "Библиотека имени Ленина",
        //        GeoLat = 37.610489,
        //        GeoLong = 55.752308,
        //        Line = "Сокольническая",
        //        Traffic = 1.0
        //    });
        //    stations.Add(new Station()
        //    {
        //        Id = 2,
        //        PlaceName = "Александровский сад",
        //        GeoLat = 37.608644,
        //        GeoLong = 55.75226,
        //        Line = "Арбатско-Покровская",
        //        Traffic = 1.2
        //    });
        //    stations.Add(new Station()
        //    {
        //        Id = 3,
        //        PlaceName = "Боровицкая",
        //        GeoLat = 37.609073,
        //        GeoLong = 55.750509,
        //        Line = "Серпуховско-Тимирязевская",
        //        Traffic = 1.0
        //    });

        //    return Json(stations, JsonRequestBehavior.AllowGet);
        //}




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
    }
}