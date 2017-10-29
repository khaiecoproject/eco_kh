using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoKh.DAL.Entity
{
   public class declarac : Entity
    {
       // [Key]
       // public int id_declar { get; set; }
        public int number_dec { get; set; }
        public string dara_reg_dec { get; set; }

      //  public virtual subject_hozaystva subject_hozaystva { get; set; }
    }
}
