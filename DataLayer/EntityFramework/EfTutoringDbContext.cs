using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EntityFramework
{
    public class EfTutoringDbContext : DbContext
    {
        public DbSet<TutorStudentDal> Tutors { get; set; }
        //public DbSet<TutoringSessionDal> Sessions { get; set; }

        public EfTutoringDbContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EfTutoringDbContext>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EfTutoringDbContext>());
        }
    }
}
