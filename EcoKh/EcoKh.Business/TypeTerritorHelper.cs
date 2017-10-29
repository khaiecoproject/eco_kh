using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoKh.DAL.Entity;
using EcoKh.DAL;

namespace EcoKh.Business
{
   public class TypeTerritorHelper
    {
        public TypeTerritorHelper(IRepository repository)
        {
            this.context = repository;
        }

        private IRepository context;

        public type_territor AddTypeTer(string name)
        {
            var d = new type_territor() { type_territor_name = name };
            context.Add(d);
            context.SaveChanges();
            return d;
        }

        public void DeleteTypeTer(int id)
        {
            var d = GetTypeTer(id);
            context.Delete(d);
            context.SaveChanges();
        }

        public type_territor EditTypePZF(int id, string name)
        {
            var d = GetTypeTer(id);
            d.type_territor_name = name;
            context.SaveChanges();
            return d;
        }

        public IEnumerable<type_territor> GetTypeTer()
        {
            return context.type_territors.Select(x => { x.Id = context.type_territors.Count(s => s.Id == x.Id); return x; });
        }

        public type_territor GetTypeTer(int id)
        {
            return GetTypeTer().First(x => x.Id == id);
        }
    }
}
