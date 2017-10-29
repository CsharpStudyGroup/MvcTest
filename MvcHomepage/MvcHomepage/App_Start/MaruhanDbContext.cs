using MaruhanItem.Diary;
using MaruhanItem.Muser;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations.History;
using System.Linq;
using System.Web;

namespace MvcHomepage.App_Start
{
    public class MaruhanDbContext : DbContext
    {
        public MaruhanDbContext() : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<HistoryRow>().Property(h => h.MigrationId).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<HistoryRow>().Property(h => h.ContextKey).HasMaxLength(200).IsRequired();
        }

        public DbSet<MuserItem> MUser { get; set; }
        public DbSet<DiaryItem> Diary { get; set; }
    }
}