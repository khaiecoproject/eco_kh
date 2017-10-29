using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoKh.DAL.Entity;

namespace EcoKh.DAL
{
   public class Repository : IRepository
    {
        private PzfContext context = new PzfContext();

        public IEnumerable<prirodo_zaschit_fond> prirodo_zaschit_fonds
        {
            get
            {
                return context.prirodo_zaschit_fonds.ToList();
            }
        }

        public IEnumerable<subject_hozaystva> subject_hozaystvas
        {
            get
            {
                return context.subject_hozaystvas;
            }
        }

        public IEnumerable<date_reestr_card> date_reestr_cards
        {
            get
            {
                return context.date_reestr_cards;
            }
        }

        public IEnumerable<declarac> declaracs
        {
            get
            {
                return context.declaracs;
            }
        }

        public IEnumerable<razreshenie> razreshenies
        {
            get
            {
                return context.razreshenies;
            }
        }

        public IEnumerable<type_pzf> type_pzfs
        {
            get
            {
                return context.type_pzfs.ToList();
            }
        }

        public IEnumerable<type_territor> type_territors
        {
            get
            {
                return context.type_territors.ToList();
            }
        }

        public IEnumerable<znachenie_pzf> znachenie_pzfs
        {
            get
            {
                return context.znachenie_pzfs.ToList();
            }
        }

        public void Add<T>(T entity) where T : EcoKh.DAL.Entity.Entity
        {
            this.context.Set<T>().Add(entity);
        }

        public void Delete<T>(T entity) where T : EcoKh.DAL.Entity.Entity
        {
            this.context.Set<T>().Remove(entity);
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}
