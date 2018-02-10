using EcoKh.Business;
using EcoKh.DAL.Entity;
using EcoKh.DAL;
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
        SubjHozHelper subhelp = new SubjHozHelper(new Repository());

        //ZnachenieHelper znach = new ZnachenieHelper(new Repository());
        //TypeTerritorHelper typreter = new TypeTerritorHelper(new Repository());
        //TypePZF_Helper typepzf = new TypePZF_Helper(new Repository());

        //public ActionResult Index(int pid)
        //{
        //    var vm = new PZFViewModel() { fond = pzfhelp.GetPZFs(), territor = typreter.GetTypeTer(pid), type = typepzf.GetTypePZF(pid), znachenie = znach.GetZnachenie(pid) };
        //    return View(vm);
        //}

        public ActionResult Index()
        {
            var model = new CommonViewModel
            {
                fond = pzfhelp.GetPZFs(),
                subhoz = subhelp.GetSubs(),
            };
            return View(model);
        }

        public JsonResult GetData()
        {

            var vm = new CommonViewModel
            {
                fond = pzfhelp.GetPZFs(),
                subhoz = subhelp.GetSubs(),
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

        // GET: /PZF/Delete/

        public ActionResult Delete(int pzfId)
        {
            return View(pzfhelp.GetPZF(pzfId));
        }

        // POST: /PZF/Delete/

        [HttpPost]
        public ActionResult Delete(int pzfId, FormCollection collection)
        {
            try
            {
                pzfhelp.DeletePZF(pzfId);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: /PZF/Edit/

        public ActionResult Edit(int pzfId)
        {
            return View(pzfhelp.GetPZF(pzfId));
        }

        // POST: /PZF/Edit/

        [HttpPost]
        public ActionResult Edit(int pzfId, prirodo_zaschit_fond pzf)
        {
            try
            {
                pzfhelp.EditPZF(pzfId, pzf.name_pzf, pzf.address, pzf.ploschad.Value, pzf.reshenie, pzf.typePzf, pzf.typeTerritor, pzf.znacheniePzf, pzf.geolon.Value, pzf.geolat.Value, pzf.link);

                return RedirectToAction("About", "Home");
            }
            catch
            {
                return View();
            }
        }


        // GET: /PZF/Create

        public ActionResult Create()
        {
            return View(new prirodo_zaschit_fond());
        }

        // POST: /PZF/Create

        [HttpPost]
        public ActionResult Create(prirodo_zaschit_fond pzf)
        {
            try
            {
                pzfhelp.AddPZF(pzf.name_pzf, pzf.address, pzf.ploschad.Value, pzf.reshenie, pzf.typePzf, pzf.typeTerritor,pzf.znacheniePzf, pzf.geolon.Value, pzf.geolat.Value, pzf.link);
                return RedirectToAction("About", "Home");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Contact()
        {
            var model = new AnalitycsViewModel
            {
                PzfCount = pzfhelp.AnalitycsCount(),
                GlobZnach = pzfhelp.AnalitycsGlobZnach(),
                LocalZnach = pzfhelp.AnalitycsLocalZnach(),
                KeyTerCount = pzfhelp.AnalitycsKeyTerCount(),
                BufTerCount = pzfhelp.AnalitycsBufTerCount(),
                VidTerCount = pzfhelp.AnalitycsVidTerCount(),
                SpolTerCount = pzfhelp.AnalitycsSpolTerCount(),
                EndRazr = subhelp.AnalitycsEndRazr(),
                EzegodInvProizv = subhelp.AnalitycsEzegodInvProizv(),
                EzegodInvUtil = subhelp.AnalitycsEzegodInvUtil(),
                DecReq = subhelp.AnalitycsDecReq(),
                SubCount = subhelp.AnalitycsSubCount(),
                SOthod = subhelp.AnalitycsSOthod(),
                BezOthod = subhelp.AnalitycsBezOthod()
            };

            return View(model);
        }
    }
}