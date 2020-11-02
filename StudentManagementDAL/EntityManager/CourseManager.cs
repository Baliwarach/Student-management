using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementDAL;

namespace StudentManagementDAL
{
    public class CourseManager : IEntityManager<Course>
    {
        StudentDBEntities db = new StudentDBEntities();
        public IQueryable<Course> FindAll()
        {
            return this.db.Courses.Where(p=>p.IsActive == true);
        }

        public Course Find(int id)
        {
            return this.db.Courses.Find(id);
        }

        public void Save(Course course)
        {
            this.db.Courses.Add(course);
            this.db.SaveChanges();
        }

        public void Modify(Course Course)
        {
            db.Entry(Course).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Course course = this.Find(id);
            db.Courses.Remove(course);
            db.SaveChanges();
        }

        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}
