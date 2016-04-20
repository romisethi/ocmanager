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
        public virtual DbSet<OCManager.Entities.DBEntities.Person> Person { get; set; }
        public virtual DbSet<OCManager.Entities.DBEntities.Patient> Patient { get; set; }
        public virtual DbSet<OCManager.Entities.DBEntities.Number> Number { get; set; }
        public virtual DbSet<OCManager.Entities.DBEntities.PersonNumber> PersonNumber { get; set; }
        public virtual DbSet<OCManager.Entities.DBEntities.User> User { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<EventTask>().ToTable("tblEvent");
            modelBuilder.Entity<OCManager.Entities.DBEntities.Occurence>().ToTable("occurences");
            modelBuilder.Entity<OCManager.Entities.DBEntities.Person>().ToTable("person");
            modelBuilder.Entity<OCManager.Entities.DBEntities.Patient>().ToTable("patient");
            modelBuilder.Entity<OCManager.Entities.DBEntities.PersonNumber>().ToTable("person_number");
            modelBuilder.Entity<OCManager.Entities.DBEntities.Number>().ToTable("number");
            modelBuilder.Entity<OCManager.Entities.DBEntities.User>().ToTable("user");
            
        }
    }
}
