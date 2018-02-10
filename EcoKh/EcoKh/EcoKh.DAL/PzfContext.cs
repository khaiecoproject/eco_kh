using EcoKh.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoKh.DAL
{
    public class PzfContext : DbContext
    {
        public PzfContext()
            : base("PzfContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<PzfContext>());
        }

        public DbSet<prirodo_zaschit_fond> prirodo_zaschit_fonds { get; set; }
        public DbSet<type_pzf> type_pzfs { get; set; }
        public DbSet<znachenie_pzf> znachenie_pzfs { get; set; }
        public DbSet<type_territor> type_territors { get; set; }
        public DbSet<date_reestr_card> date_reestr_cards { get; set; }
        public DbSet<declarac> declaracs { get; set; }
        public DbSet<razreshenie> razreshenies { get; set; }
        public DbSet<subject_hozaystva> subject_hozaystvas { get; set; }
    }
}
