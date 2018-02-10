using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoKh.DAL.Entity
{
    public class znachenie_pzf : Entity
    {
        //[Key]
        // public int id_znachenie_pzf { get; set; }
        public string znachenie_pzf_name { get; set; }
        //public virtual prirodo_zaschit_fond prirodo_zaschit_fond { get; set; }

        //public int? pzfId { get; set; }
    }
}
