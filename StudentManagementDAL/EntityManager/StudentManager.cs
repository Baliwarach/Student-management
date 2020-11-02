using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementDAL;

namespace StudentManagementDAL
{
    public class StudentManager : IEntityManager<Student>
    {
        StudentDBEntities db = new StudentDBEntities();
        public IQueryable<Student> FindAll()
        {
            return this.db.Students.Where(p=>p.IsActive == true);
        }

        public Student Find(int id)
        {
            return this.db.Students.Find(id);
        }

        public void Save(Student Student)
        {
            this.db.Students.Add(Student);
            this.db.SaveChanges();
        }

        public void Modify(Student Student)
        {
            db.Entry(Student).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Student Student = this.Find(id);
            db.Students.Remove(Student);
            db.SaveChanges();
        }

        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}
