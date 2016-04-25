using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Tutors
{
    public class TutorStudent
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string LastNumber { get; set; }
        
        //public ICollection<TUtoringSession> Sessions;

        public int GetTutoringHours()
        {
            return 0;
        }
    }
}
