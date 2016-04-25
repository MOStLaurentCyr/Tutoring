using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Tutors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer.Entities;
using DataLayer;
using FluentAssertions;
using NSubstitute;

namespace Domain.UnitTest
{
    [TestClass]
    public class TutorManagerTest
    {
        private TutorStudentManager _tutorService;
        private IRepository<TutorStudentDal> _tutorRepo;
        [TestInitialize]
        public void TutorManagerTestInit()
        {
            _tutorRepo = Substitute.For<IRepository<TutorStudentDal>>();
            _tutorService = new TutorStudentManager(_tutorRepo);
        }
        [TestMethod]
        public void GetAllTutors_ShouldReturnAlltutors()
        {
            //Arrange
            const int tutorCount = 3;

            var tutorDal1 = new TutorStudentDal(){Id =1 , Number = 1234567, LastName = "Zozo"};
            var tutorDal2 = new TutorStudentDal() { Id = 2, Number = 2345678, LastName = "Coco" };
            var tutorDal3 = new TutorStudentDal() { Id = 3, Number = 3456789, LastName = "Toto" };
            var tutors = new List<TutorStudentDal>() {tutorDal1, tutorDal2, tutorDal3};

            _tutorRepo.GetAll().Returns((tutors.AsQueryable()));

            //Act
            var tutorStudentList = _tutorService.GetAllTutors();

            //Assert
            Assert.AreEqual(tutorCount, tutorStudentList.Count());

            //Avec Fluent Assertion
            tutorStudentList.Count().ShouldBeEquivalentTo((tutorCount));
        }
    }
}
