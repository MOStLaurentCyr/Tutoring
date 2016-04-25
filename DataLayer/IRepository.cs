using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
     public interface IRepository<T> where T:EntityDal
     {

         IQueryable<T> GetAll();

         T GetByID(int id);

         void Add(T tutor);

         void Update(T tutor);

         void Delete(T tutor);

         void DeleteAll();

     }
}
