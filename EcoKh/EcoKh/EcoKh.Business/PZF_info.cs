using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoKh.Business
{
    public class PZF_info
    {
        public PZF_info(string p_name, int znach_p)
        {
            this.pzf_name = p_name;
            this.znachenie_pzf = znach_p;
        }

        public string pzf_name { get; set; }
        public int znachenie_pzf { get; set; }
    }
}
