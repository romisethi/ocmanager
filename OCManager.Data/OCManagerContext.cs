using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OCManager.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OCManager.Data
{
    public class OCManagerContext : DbContext
    {
        public OCManagerContext()
            : base("OCManagerConnection")
        {
        }

        //public virtual DbSet<EventTask> EventTasks { get; set; }
        public virtual DbSet<OCManager.Entities.DBEntities.Occurence> Occurences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<EventTask>().ToTable("tblEvent");
            modelBuilder.Entity<OCManager.Entities.DBEntities.Occurence>().ToTable("occurences");
            
        }
    }
}
