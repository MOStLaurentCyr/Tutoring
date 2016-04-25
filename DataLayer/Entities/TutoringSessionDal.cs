using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class TutoringSessionDal
    {
        public DateTime DateTimeSession { get; set; }
        public int LenghtSession { get; set; }

        public int TutorStudentDalId { get; set; }

        public virtual TutorStudentDal TutorStudentDal { get; set; }

    }
}
