using DomainLayer.Tutors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.ViewObjects;
using ConsoleApplication1.Views;
using DataLayer.Entities;
using DataLayer.EntityFramework;
using NSubstitute;

namespace ConsoleApplication1.Controllers
{
    public class TutoringController
    {
        private readonly TutorStudentManager _tutorService;


        public TutoringController()
        {
            _tutorService = new TutorStudentManager(new EfEntityRepository<TutorStudentDal>(new EfTutoringDbContext()));
        }

        public void ListAll()
        {
            IQueryable<TutorStudent> tutorList = _tutorService.GetAllTutors();

            List<TutorListVO> tutorsListView = new List<TutorListVO>();

            foreach (var tutor in tutorList)
            {
                tutorsListView.Add((new TutorListVO()
                {
                    Number = tutor.Number,
                    LastName = tutor.LastNumber
                }));
            }

            new TutorListView(tutorsListView, this).Display();
        }
    }
}
