using StudentManagementBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementDAL;
namespace StudentManagementBusiness
{
    public interface IStudentRegistrationBL
    {
        void Save(Student student);
        List<Student> List();
        void Modify(Student student);
        void Delete(int id);
        void AddCourses(int studentID, List<int> courseIDs);
        void RemoveStudentCourses(int studentID, List<int> courseIDs);
        Student Find(int id);
    }
}
