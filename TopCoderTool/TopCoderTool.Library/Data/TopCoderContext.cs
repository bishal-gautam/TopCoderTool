using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoderTool.Library.Data
{
    public class TopCoderContext : DbContext
    {
        public TopCoderContext()
            :base("name=DefaultConnection")
        {

        }

        public virtual DbSet<TopcoderData> TopcoderData { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
