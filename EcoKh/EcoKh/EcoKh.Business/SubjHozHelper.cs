using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoKh.DAL.Entity;
using EcoKh.DAL;

namespace EcoKh.Business
{
    public class SubjHozHelper
    {
        public SubjHozHelper(IRepository repository)
        {
            this.context = repository;
        }
        private IRepository context;

        //Creaate
        public subject_hozaystva AddSubHoz(
            string subname,
            int kodedrpou,
            string classificat,
            string kvedkod,
            string uraddr,
            string fizaddr,
            float lon,
            float lat,
            string nalothod,
            string neobhrazr,
            string numbrazr,
            DateTime datapolucrazr,
            DateTime dataokonrazr,
            string neobdecl,
            string naldecl,
            int numdecl,
            DateTime datadecl,
            string neobintervalpass,
            string neobreestcardobj,
            string nalreestcardobj,
            DateTime dataproiz,
            DateTime datautil)
        {
            var d = new subject_hozaystva()
            {
                name_sub_hoz = subname,
                kod_edrpou = kodedrpou,
                classificator = classificat,
                kved = kvedkod,
                urid_address = uraddr,
                fiz_address = fizaddr,
                geolon = lon,
                geolat = lat,
                nalichie_othodov = nalothod,
                neobhod_razresh = neobhrazr,
                number_razr = numbrazr,
                data_poluch_razr = datapolucrazr,
                data_okon_razr = dataokonrazr,
                neobhod_declar = neobdecl,
                nalichie_declar = naldecl,
                number_dec = numdecl,
                data_reg_dec = datadecl,
                neobhod_interval_passport = neobintervalpass,
                neobhod_reesrt_card_obj = neobreestcardobj,
                nalichie_reestr_card_obj = nalreestcardobj,
                data_for_proiz = dataproiz,
                data_for_util = datautil
            };
            context.Add(d);
            context.SaveChanges();
            return d;
        }

        //Delete
        public void DeleteSubHoz(int id)
        {
            var d = GetSubHoz(id);
            context.Delete(d);
            context.SaveChanges();
        }

        //Edit
        public subject_hozaystva EditSubHoz(
            int id,
            string subname,
            int kodedrpou,
            string classificat,
            string kvedkod,
            string uraddr,
            string fizaddr,
            float lon,
            float lat,
            string nalothod,
            string neobhrazr,
            string numbrazr,
            DateTime datapolucrazr,
            DateTime dataokonrazr,
            string neobdecl,
            string naldecl,
            int numdecl,
            DateTime datadecl,
            string neobintervalpass,
            string neobreestcardobj,
            string nalreestcardobj,
            DateTime dataproiz,
            DateTime datautil)
        {
            var s = GetSubHoz(id);
            s.name_sub_hoz = subname;
            s.kod_edrpou = kodedrpou;
            s.classificator = classificat;
            s.kved = kvedkod;
            s.urid_address = uraddr;
            s.fiz_address = fizaddr;
            s.geolon = lon;
            s.geolat = lat;
            s.nalichie_othodov = nalothod;
            s.neobhod_razresh = neobhrazr;
            s.number_razr = numbrazr;
            s.data_poluch_razr = datapolucrazr;
            s.data_okon_razr = dataokonrazr;
            s.neobhod_declar = neobdecl;
            s.nalichie_declar = naldecl;
            s.number_dec = numdecl;
            s.data_reg_dec = datadecl;
            s.neobhod_interval_passport = neobintervalpass;
            s.neobhod_reesrt_card_obj = neobreestcardobj;
            s.nalichie_reestr_card_obj = nalreestcardobj;
            s.data_for_proiz = dataproiz;
            s.data_for_util = datautil;
            context.SaveChanges();
            return s;
        }


        public IEnumerable<subject_hozaystva> GetSubs()
        {
            return context.subject_hozaystvas.ToList();
        }

        public subject_hozaystva GetSubHoz(int id)
        {
            return GetSubs().First(x => x.Id == id);
        }

        public List<subject_hozaystva> AnalitycsEndRazr()
        {
            return GetSubs().Where(x => x.data_okon_razr <= DateTime.Today).ToList();
        }

        public List<subject_hozaystva> AnalitycsEzegodInvProizv()
        {
            return GetSubs().Where(x => (x.neobhod_interval_passport == "Потрібно" && x.data_for_proiz.Value.AddYears(1) <= DateTime.Today)).ToList();
        }

        public List<subject_hozaystva> AnalitycsEzegodInvUtil()
        {
            return GetSubs().Where(x => (x.neobhod_interval_passport == "Потрібно" && x.data_for_util.Value.AddYears(1) <= DateTime.Today)).ToList();
        }

        public List<subject_hozaystva> AnalitycsDecReq()
        {
            return GetSubs().Where(x => (x.neobhod_declar == "Потрібна декларація" && x.nalichie_declar == "Не має декларації")).ToList();
        }

        public int AnalitycsSubCount()
        {
            return GetSubs().Count();
        }

        public int AnalitycsSOthod()
        {
            return GetSubs().Count(x => x.nalichie_othodov == "Має відходи");
        }

        public int AnalitycsBezOthod()
        {
            return GetSubs().Count(x => x.nalichie_othodov == "Не має відходів");
        }
    }
}
