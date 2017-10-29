using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoKh.DAL.Entity;
using EcoKh.DAL;

namespace EcoKh.Business
{
   public class TypePZF_Helper
    {
        public TypePZF_Helper (IRepository repository)
        {
            this.context = repository;
        }

        private IRepository context;

        public type_pzf AddTypePZF(string name)
        {
            var d = new type_pzf() { type_pzf_name = name };
            context.Add(d);
            context.SaveChanges();
            return d;
        }

        public void DeleteTypePZF(int id)
        {
            var d = GetTypePZF(id);
            context.Delete(d);
            context.SaveChanges();
        }

        public type_pzf EditTypePZF(int id, string name)
        {
            var d = GetTypePZF(id);
            d.type_pzf_name = name;
            context.SaveChanges();
            return d;
        }

        public IEnumerable<type_pzf> GetTypePZF()
        {
            return context.type_pzfs.Select(x => { x.Id = context.type_pzfs.Count(s => s.Id == x.Id); return x; });
        }

        public type_pzf GetTypePZF(int id)
        {
            return GetTypePZF().First(x => x.Id == id);
        }

    }
}
