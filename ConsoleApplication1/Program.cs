using DataLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Controllers;
using DataLayer.Entities;
using TestsUtility;

namespace Tutoring
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDataSeeder dataSeeder = new TestDataSeeder();

            var tutorController = new TutoringController();
            tutorController.ListAll();

            var appContext = new EfEntityRepository<TutorStudentDal>();
            var tutorRepo = new TutorStudentDal();
            var sessionRepo = new EfEntityRepository<TutoringSessionDal>(appContext);

            /*   var sessionRepo = new EfEntityRepository<TutoringSessionDal>();

            tutorRepo.DeleteAll();
            sessionRepo.DeleteAll();

            var tutorX = new TutorStudentDal() {Number = 125688, LastName = "Wayne"};
            tutorRepo.Add(tutorX);

            var tutorXFromBD = tutorRepo.GetByID(tutorX.Id);
            var sessionX = new TutoringSessionDal()
            {
                DateTimeSession = new DateTime(2016, 03, 16),
                LengthSession = 1,
                Tutor = tutorXFromBD
            };

            sessionRepo.Add(sessionX);

            //Consultation
            var tutorList1 = tutorRepo.GetAll();
            DiplaytutorList(tutorList1);

            tutorRepo.Add(tutor1);

            //Consultation
            var tutorList2 = tutorRepo.GetAll();
            Console.WriteLine("liste des Tuteurs");

            foreach (var tutor in tutorList2)
            {
                Console.WriteLine(tutor.Number + " - " + tutor.LastName);
            }
            Console.ReadKey();

            tutor1.LastName = "Nori";

            tutorRepo.Update(tutor1);

            //Consultation
            DiplaytutorList(tutorList2);

            tutorRepo.Delete(tutor1);

            var tutorList4 = tutorRepo.GetAll();
            Console.WriteLine("liste des Tuteurs");
            foreach (var tutor in tutorList4)
            {
                Console.WriteLine(tutor.Number + " - " + tutor.LastName);
            }
            Console.ReadKey();

            var tutorListC = tutorRepo.GetAll();
            var tutorsGagnon = tutorListC.Where(t => t.LastName == "Gagnon");
        }

        private static void DiplaytutorList(IQueryable<TutorStudentDal> listTutor)
        {
            Console.WriteLine(("Nombre de Tuteurs: " + listTutor.Count()));
            foreach (var tutor in listTutor)
            {
                Console.WriteLine(tutor.Number + " - " + tutor.LastName);
            }
            Console.ReadKey();
        }*/
        }
    }
}