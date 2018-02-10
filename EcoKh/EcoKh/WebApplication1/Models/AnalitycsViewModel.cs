using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EcoKh.DAL.Entity;

namespace EcoKh.Web.Models
{
    public class AnalitycsViewModel
    {
        public int PzfCount { get; set; }
        public List<prirodo_zaschit_fond> GlobZnach { get; set; }
        public List<prirodo_zaschit_fond> LocalZnach { get; set; }
        public int KeyTerCount { get; set; }
        public int BufTerCount { get; set; }
        public int VidTerCount { get; set; }
        public int SpolTerCount { get; set; }
        public List<subject_hozaystva> EndRazr { get; set; }
        public List<subject_hozaystva> EzegodInvProizv { get; set; }
        public List<subject_hozaystva> EzegodInvUtil { get; set; }
        public List<subject_hozaystva> DecReq { get; set; }
        public int SubCount { get; set; }
        public int SOthod { get; set; }
        public int BezOthod { get; set; }
    }
}