using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ContosoUniversity.DAL
{
    public class SchoolContext : DbContext
    {

        public SchoolContext() : base("SchoolContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Career> Careers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // se indica que no queremos que se pongan en plural el nombre de nuestras tablas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}