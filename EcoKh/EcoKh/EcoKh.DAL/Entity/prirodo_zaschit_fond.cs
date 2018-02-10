using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoKh.DAL.Entity
{
    public class prirodo_zaschit_fond : Entity
    {
        //  [Key]
        //  public int id_pzf { get; set; }
        public string name_pzf { get; set; }
        public string address { get; set; }
        public System.Nullable<float> ploschad { get; set; }
        public string reshenie { get; set; }
        public string typePzf { get; set; }
        public string typeTerritor { get; set; }
        public string znacheniePzf { get; set; }
        public System.Nullable<float> geolon { get; set; }
        public System.Nullable<float> geolat { get; set; }
        public string link { get; set; }


        //[Display(Name = "Znachenie")]
        // public int ZnacheniePzfId { get; set; }

        //[ForeignKey("Id")]

        //public virtual List<znachenie_pzf> znachenies { get; set; }
        //public virtual type_pzf type { get; set; }
        //public virtual type_territor territor { get; set; }
        
        //public virtual znachenie_pzf znachenie { get; set; }
        //public virtual type_pzf type { get; set; }
        //public virtual type_territor territor { get; set; }

        //public virtual ICollection<type_pzf> type_pzfs { get; set; }
        //public virtual ICollection<znachenie_pzf> znachenie_pzfs { get; set; }
        //public virtual ICollection<type_territor> type_territors { get; set; }
    }
}
