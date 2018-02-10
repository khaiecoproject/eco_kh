using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcoKh.Business;
using EcoKh.DAL.Entity;
using EcoKh.DAL;
using EcoKh.Web.Models;

namespace EcoKh.Web.Controllers
{
    public class SubHozController : Controller
    {
        SubjHozHelper subhelp = new SubjHozHelper(new Repository());


        // GET: SubHoz
        public ActionResult AboutSubHoz()
        {
            var submodel = new SubHozViewModel
            {
                subhoz = subhelp.GetSubs(),
            };

            return View(submodel);
        }
        // GET: /SubHoz/Delete
        public ActionResult DeleteSubHoz(int subId)
        {
            return View(subhelp.GetSubHoz(subId));
        }

        // POST: /SubHoz/Delete/

        [HttpPost]
        public ActionResult DeleteSubHoz(int subId, FormCollection collection)
        {
            try
            {
                subhelp.DeleteSubHoz(subId);
                return RedirectToAction("AboutSubHoz", "SubHoz");
            }
            catch
            {
                return View();
            }

        }

        // GET: /PZF/Edit/

        public ActionResult EditSubHoz(int subId)
        {
            return View(subhelp.GetSubHoz(subId));
        }

        // POST: /PZF/Edit/

        [HttpPost]
        public ActionResult EditSubHoz(int subId, subject_hozaystva sub)
        {
            try
            {
                subhelp.EditSubHoz(
                    subId,
                    sub.name_sub_hoz,
                    sub.kod_edrpou.Value,
                    sub.classificator,
                    sub.kved,
                    sub.urid_address,
                    sub.fiz_address,
                    sub.geolon.Value,
                    sub.geolat.Value,
                    sub.nalichie_othodov,
                    sub.neobhod_razresh,
                    sub.number_razr,
                    sub.data_poluch_razr.Value,
                    sub.data_okon_razr.Value,
                    sub.neobhod_declar,
                    sub.nalichie_declar,
                    sub.number_dec.Value,
                    sub.data_reg_dec.Value,
                    sub.neobhod_interval_passport,
                    sub.neobhod_reesrt_card_obj,
                    sub.nalichie_reestr_card_obj,
                    sub.data_for_proiz.Value,
                    sub.data_for_util.Value
                    );

                return RedirectToAction("AboutSubHoz", "SubHoz");
            }
            catch
            {
                return View();
            }
        }


        // GET: /PZF/Create

        public ActionResult CreateSubHoz()
        {
            return View(new subject_hozaystva());
        }

        // POST: /PZF/Create

        [HttpPost]
        public ActionResult CreateSubHoz(subject_hozaystva sub)
        {
            try
            {
                subhelp.AddSubHoz(
                    sub.name_sub_hoz,
                    sub.kod_edrpou.Value,
                    sub.classificator,
                    sub.kved,
                    sub.urid_address,
                    sub.fiz_address,
                    sub.geolon.Value,
                    sub.geolat.Value,
                    sub.nalichie_othodov,
                    sub.neobhod_razresh,
                    sub.number_razr,
                    sub.data_poluch_razr.Value,
                    sub.data_okon_razr.Value,
                    sub.neobhod_declar,
                    sub.nalichie_declar,
                    sub.number_dec.Value,
                    sub.data_reg_dec.Value,
                    sub.neobhod_interval_passport,
                    sub.neobhod_reesrt_card_obj,
                    sub.nalichie_reestr_card_obj,
                    sub.data_for_proiz.Value,
                    sub.data_for_util.Value
                    );
                return RedirectToAction("AboutSubHoz", "SubHoz");
            }
            catch
            {
                return View();
            }
        }
    }
}