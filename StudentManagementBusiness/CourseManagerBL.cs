using StudentManagementBusiness.Models;
using StudentManagementDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementBusiness
{
    public class CourseManagerBL : ICourseManagerBL
    {
        private CourseManager courseManager;
        public CourseManagerBL()
        {
            courseManager = new CourseManager();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Course Find(int id)
        {
            return courseManager.Find(id);
        }

        public List<Course> List()
        {
            return courseManager.FindAll().ToList();
        }

        public void Modify(Course course)
        {
            throw new NotImplementedException();
        }

        public void Save(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
