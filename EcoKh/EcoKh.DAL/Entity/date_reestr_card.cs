using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoKh.DAL.Entity
{
   public class date_reestr_card : Entity
    {
        //[Key]
        //public int id_data_reestr_card { get; set; }
        public string data_for_proiz { get; set; }
        public string data_for_util { get; set; }

        //public virtual subject_hozaystva subject_hozaystva { get; set; }
    }
}
