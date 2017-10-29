using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoKh.DAL.Entity;
using EcoKh.DAL;

namespace EcoKh.Business
{
    public class ZnachenieHelper
    {
        public ZnachenieHelper (IRepository repository)
        {
            this.context = repository;
        }

        private IRepository context;

        public znachenie_pzf AddZnachenie(string name)
        {
            var d = new znachenie_pzf() { znachenie_pzf_name = name };
            context.Add(d);
            context.SaveChanges();
            return d;
        }

        public void DeleteZnachenie(int id)
        {
            var d = GetZnachenie(id);
            context.Delete(d);
            context.SaveChanges();
        }

        public znachenie_pzf EditZnachenie (int id, string name)
        {
            var d = GetZnachenie(id);
            d.znachenie_pzf_name = name;
            context.SaveChanges();
            return d;
        }

        public IEnumerable<znachenie_pzf> GetZnachenie()
        {
            return context.znachenie_pzfs.Select(x => { x.Id = context.znachenie_pzfs.Count(s => s.Id == x.Id); return x; });
        }

        public znachenie_pzf GetZnachenie(int id)
        {
            return GetZnachenie().First(x => x.Id == id);
        }

    }
}
