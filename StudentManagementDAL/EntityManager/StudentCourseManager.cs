using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementDAL;

namespace StudentManagementDAL
{
    public class StudentCourseManager : IEntityManager<StudentEnrollment>
    {
        StudentDBEntities db = new StudentDBEntities();
        public IQueryable<StudentEnrollment> FindAll()
        {
            return this.db.StudentEnrollments.Where(p => p.IsActive == true);
        }

        public IQueryable<StudentEnrollment> FindAllByStudentID(int studentID)
        {
            return this.db.StudentEnrollments.Where(p => p.StudentID == studentID && p.IsActive == true);
        }

        public StudentEnrollment Find(int id)
        {
            return this.db.StudentEnrollments.Find(id);
        }

        public void Save(StudentEnrollment studentEnrollment)
        {
            this.db.StudentEnrollments.Add(studentEnrollment);
            this.db.SaveChanges();
        }

        public void Modify(StudentEnrollment studentEnrollment)
        {
            db.Entry(studentEnrollment).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteEnrolementByID(int studentID, int courseID)
        {
            StudentEnrollment studentEnrollment = db.StudentEnrollments.Where(p => p.StudentID == studentID && p.CourseID == courseID).FirstOrDefault();
            Delete(studentEnrollment.ID);
        }
        public void DeleteAllEnrolementByID(int studentID)
        {
            List<StudentEnrollment> studentEnrollments = db.StudentEnrollments.Where(p => p.StudentID == studentID).ToList();
            studentEnrollments.ForEach(p=>Delete(p.ID));
        }

        public void AddEnrolementByID(int studentID, int courseID)
        {
            StudentEnrollment studentEnrollment = new StudentEnrollment();
            studentEnrollment.StudentID = studentID;
            studentEnrollment.CourseID = courseID;
            studentEnrollment.EnrolledOn = DateTime.Now;
            studentEnrollment.IsActive = true;
            Save(studentEnrollment);
        }

        public void Delete(int id)
        {
            StudentEnrollment studentEnrollment = this.Find(id);
            db.StudentEnrollments.Remove(studentEnrollment);
            db.SaveChanges();
        }

        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}
