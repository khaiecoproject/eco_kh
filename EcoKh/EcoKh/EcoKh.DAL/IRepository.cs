using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoKh.DAL.Entity;

namespace EcoKh.DAL
{
    public interface IRepository
    {
        IEnumerable<date_reestr_card> date_reestr_cards { get; }
        IEnumerable<declarac> declaracs { get; }
        IEnumerable<prirodo_zaschit_fond> prirodo_zaschit_fonds { get; }
        IEnumerable<razreshenie> razreshenies { get; }
        IEnumerable<subject_hozaystva> subject_hozaystvas { get; }
        IEnumerable<type_pzf> type_pzfs { get; }
        IEnumerable<type_territor> type_territors { get; }
        IEnumerable<znachenie_pzf> znachenie_pzfs { get; }

        void Add<T>(T entity) where T : EcoKh.DAL.Entity.Entity;

        void Delete<T>(T entity) where T : EcoKh.DAL.Entity.Entity;

        void SaveChanges();
    }
}
