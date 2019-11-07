namespace Mymagicwilltearyouapart.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HappyDBContext : DbContext
    {
        public HappyDBContext()
            : base("name=HappyDB")
        {
        }

        public virtual DbSet<Table> Table { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>()
                .Property(e => e.UserName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);
        }
    }
}
