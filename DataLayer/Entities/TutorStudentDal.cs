using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class TutorStudentDal : EntityDal
    {
        public int Number { get; set; }

        public string LastName { get; set; }

        private DbContext _dbContext;

        //Navigation Properties
        public virtual ICollection<TutoringSessionDal> SessionsDal { get; set; }

        public TutorStudentDal()
        {
            //SessionsDal = new List<TutoringSessionDal>();
        }
    }
}
