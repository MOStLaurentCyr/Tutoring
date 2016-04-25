using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Controllers;
using ConsoleApplication1.ViewObjects;
using NSubstitute.Exceptions;

namespace ConsoleApplication1.Views
{
    public class TutorListView
    {

        private readonly IEnumerable<TutorListVO> _tutorList; 

        public TutorListView(IEnumerable<TutorListVO> tutorList, TutoringController controller)
        {
            _tutorList = tutorList;
        }

        public void Display()
        {
            Console.WriteLine(_tutorList.Count());
            foreach (var tutor in _tutorList)
            {
                Console.WriteLine("Matricule" + tutor.Number + "nom" + tutor.LastName);
            }
            Console.ReadKey();
        }
    }
}
