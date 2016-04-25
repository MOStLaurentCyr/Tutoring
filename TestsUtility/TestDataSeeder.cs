using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;
using DataLayer.EntityFramework;

namespace TestsUtility
{
    public class TestDataSeeder
    {
        private IRepository<TutorStudentDal> _tutorRepo;

        public TestDataSeeder()
        {
            DbContext appContext = new EfTutoringDbContext();
            _tutorRepo = new EfEntityRepository<TutorStudentDal>(appContext);
        }

        public void ClearTables()
        {
            _tutorRepo.DeleteAll();
        }

        public void SeedTables()
        {
            addTutor(1234567, "Rose");
            addTutor(2345678, "Gagné");
            addTutor(3456789, "Leblanc");
        }

        private void addTutor(int number, string name)
        {
            _tutorRepo.Add(new TutorStudentDal()
                {
                    Number = number,
                    LastName = name
                }
            );
        }
    }
}
