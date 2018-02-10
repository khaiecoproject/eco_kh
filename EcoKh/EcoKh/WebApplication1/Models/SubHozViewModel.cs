using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EcoKh.DAL.Entity;

namespace EcoKh.Web.Models
{
    public class SubHozViewModel
    {
        public IEnumerable<subject_hozaystva> subhoz { get; set; }

    }
}