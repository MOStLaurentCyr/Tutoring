using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Entities;
using DataLayer.EntityFramework;

namespace DomainLayer.Tutors
{
    public class TutorStudentManager  // : ITutorStudentManager
    {
        private IRepository<TutorStudentDal> _tutorRepository;

        public TutorStudentManager(IRepository<TutorStudentDal> repo )
        {
            _tutorRepository = repo;
        }

        public void RegisterTutor(TutorStudentDal newTutor)
        {
            // validation: matricule unique (ou au moins 1 disponibilité)
            var tutorToAdd = new TutorStudentDal()
            {
                Number = newTutor.Number,
                LastName = newTutor.LastName
            };
            _tutorRepository.Add(tutorToAdd);
        }

        public IQueryable<TutorStudent> GetAllTutors()
        {
            var tutorsList =  new List<TutorStudent>();
            foreach (var tutor in _tutorRepository.GetAll())
            {
                tutorsList.Add(new TutorStudent()
                {
                    Id = tutor.Id,
                    Number = tutor.Number,
                    LastNumber = tutor.LastName
                });
            }

            return tutorsList.AsQueryable();
        }


    }
}
