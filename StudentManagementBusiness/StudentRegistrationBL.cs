using StudentManagementBusiness.Models;
using StudentManagementDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementBusiness
{
    public class StudentRegistrationBL : IStudentRegistrationBL
    {
        private StudentManager studentManager;
        private StudentCourseManager studentCourseManager;


        public StudentRegistrationBL()
        {
            studentManager = new StudentManager();
            studentCourseManager = new StudentCourseManager();
        }

        public void Save(Student student)
        {
            studentManager.Save(student);            
        }

        public List<Student> List()
        {
            return studentManager.FindAll().ToList();
        }

        public List<StudentEnrollment> ListAllStudentRegistrations(int studentID)
        {
            return studentCourseManager.FindAllByStudentID(studentID).ToList();
        }

        public Student Find(int id)
        {
            return studentManager.Find(id);
        }

        public void Modify(Student student)
        {
            studentManager.Modify(student);
        }

        public void AddCourses(int studentID, List<int> courseIDs)
        {
            foreach(int courseID in courseIDs)
            {
                studentCourseManager.AddEnrolementByID(studentID, courseID);
            }
        }
        public void EditCourses(int studentID, List<int> courseIDs)
        {
            studentCourseManager.DeleteAllEnrolementByID(studentID);
            foreach (int courseID in courseIDs)
            {
                studentCourseManager.AddEnrolementByID(studentID, courseID);
            }
        }

        public void DeleteAllCourses(int studentID)
        {
            studentCourseManager.DeleteAllEnrolementByID(studentID);           
        }

        public void RemoveStudentCourses(int studentID, List<int> courseIDs)
        {
            foreach (int courseID in courseIDs)
            {
                studentCourseManager.DeleteEnrolementByID(studentID, courseID);
            }
        }

        public void Delete(int id)
        {
            studentManager.Delete(id);
        }


         // StudentRegistration 


    }
}
