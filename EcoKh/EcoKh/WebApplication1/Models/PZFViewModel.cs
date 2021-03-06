﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EcoKh.DAL.Entity;

namespace EcoKh.Web.Models
{
    public class PZFViewModel
    {
        public IEnumerable<prirodo_zaschit_fond> fond { get; set; }
        public znachenie_pzf znachenie { get; set; }
        public type_pzf type { get; set; }
        public type_territor territor { get; set; }

        public IEnumerable<znachenie_pzf> znachenieList { get; set; }
        public IEnumerable<type_pzf> typePzfList { get; set; }
        public IEnumerable<type_territor> typeTerritorList { get; set; }
    }
}