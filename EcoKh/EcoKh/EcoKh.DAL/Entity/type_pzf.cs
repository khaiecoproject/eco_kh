using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoKh.DAL.Entity
{
    public class type_pzf : Entity
    {
        //[Key]
        //public int id_type_pzf { get; set; }
        public string type_pzf_name { get; set; }

     //   public virtual prirodo_zaschit_fond prirodo_zaschit_fond { get; set; }
    }
}
