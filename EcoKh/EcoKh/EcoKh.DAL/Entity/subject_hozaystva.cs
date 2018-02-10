using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoKh.DAL.Entity
{
    public class subject_hozaystva : Entity
    {
        //[Key]
        //public int id_sub_hoz { get; set; }
        public string name_sub_hoz { get; set; }
        public System.Nullable<int> kod_edrpou { get; set; }
        public string classificator { get; set; }
        public string kved { get; set; }
        public string urid_address { get; set; }
        public string fiz_address { get; set; }
        public System.Nullable<float> geolon { get; set; }
        public System.Nullable<float> geolat { get; set; }
        public string nalichie_othodov { get; set; }
        public string neobhod_razresh { get; set; }
        public string number_razr { get; set; }
        public DateTime? data_poluch_razr { get; set; }
        public DateTime? data_okon_razr { get; set; }
        public string neobhod_declar { get; set; }
        public string nalichie_declar { get; set; }
        public int? number_dec { get; set; }
        public DateTime? data_reg_dec { get; set; }
        public string neobhod_interval_passport { get; set; }
        public string neobhod_reesrt_card_obj { get; set; }
        public string nalichie_reestr_card_obj { get; set; }
        public DateTime? data_for_proiz { get; set; }
        public DateTime? data_for_util { get; set; }


        //public virtual IEnumerable<razreshenie> razreshenies { get; set; }
        //public virtual IEnumerable<declarac> declaracs { get; set; }
        //public virtual IEnumerable<date_reestr_card> date_reestr_cards { get; set; }
    }
}
