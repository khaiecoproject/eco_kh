using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoKh.DAL.Entity;
using EcoKh.DAL;

namespace EcoKh.Business
{
    public class pzf_helper
    {

        public pzf_helper (IRepository repository)
        {
            this.context = repository;
            this.znachnies = new ZnachenieHelper(this.context);
            this.type_territors = new TypeTerritorHelper(this.context);
            this.type_pzfs = new TypePZF_Helper(this.context);
        }

        private IRepository context;
        private TypePZF_Helper type_pzfs;
        private TypeTerritorHelper type_territors;
        private ZnachenieHelper znachnies;

        public prirodo_zaschit_fond AddPZF(string name, string address, float plosch, float lon, float lat, int znachId, int typeterId, int typepfId, string resh, string lnk)
        {
            var d = new prirodo_zaschit_fond() { name_pzf = name, address = address, ploschad = plosch, geolon = lon, geolat= lat, reshenie = resh, link = lnk};
            d.znachenie = znachnies.GetZnachenie(znachId);
            d.territor = type_territors.GetTypeTer(typeterId);
            d.type = type_pzfs.GetTypePZF(typepfId);
            context.Add(d);
            context.SaveChanges();
            return d;
        }

        public void DeletePZF(int id)
        {
            var d = GetPZF(id);
            context.Delete(d);
            context.SaveChanges();
        }

        public prirodo_zaschit_fond EditPZF(int id, string name, string address, float plosch, float lon, float lat, int znachId, int typeterId, int typepfId, string resh, string lnk)
        {
            var d = GetPZF(id);
            d.name_pzf = name;
            d.address = address;
            d.ploschad = plosch;
            d.reshenie = resh;
            d.geolat = lat;
            d.geolon = lon;
            d.type = type_pzfs.GetTypePZF(typepfId);
            d.territor = type_territors.GetTypeTer(typeterId);
            d.znachenie = znachnies.GetZnachenie(znachId);
            context.Add(d);
            context.SaveChanges();
            return d;
        }

        public IEnumerable<prirodo_zaschit_fond> GetPZFs()
        {
            return context.prirodo_zaschit_fonds;
        }

        public IEnumerable<prirodo_zaschit_fond> GetPZFs(int type_pzfID, int znachID, int terrID)
        {
            return context.prirodo_zaschit_fonds.Where(x => (x.type != null && x.type.Id == type_pzfID) && (x.znachenie != null && x.znachenie.Id == znachID) && (x.territor != null && x.territor.Id == terrID)).ToList();
        }

        public prirodo_zaschit_fond GetPZF(int id)
        {
            return GetPZFs().First(x => x.Id == id);
        }


        //public pzf_helper(IRepository repository)
        //{
        //    this.context = repository;
        //}

        //private IRepository context;

        //public IEnumerable<PZF_info> GetPZFinfo()
        //{
        //    Repository repo = new Repository();
        //    return repo.prirodo_zaschit_fonds.ToList().Select(pzf => new PZF_info(pzf.name_pzf, this.GetZnachenieNumber(pzf)));
        //}

        //private int GetZnachenieNumber(prirodo_zaschit_fond pzf)
        //{
        //    var znach = pzf.znachenie_pzfs.ToList();
        //    return znach != null ? znach.Count() : 0;
        //}
    }
}
