using EcoKh.Business;
using EcoKh.DAL.Entity;
using EcoKh.DAL;
//using EcoKh.Models;
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

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var model = new PZFViewModel
            {
                fond = pzfhelp.GetPZFs(),
            };
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}