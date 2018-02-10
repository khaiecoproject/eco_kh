using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoKh.DAL.Entity
{
    public class razreshenie : Entity
    {
        //[Key]
        //public int id_razreshenie { get; set; }
        public int number_razr { get; set; }
        public string data_poluch_razr { get; set; }
        public string data_okon_razr { get; set; }

        //public virtual subject_hozaystva subject_hozaystva { get; set; }
    }
}
