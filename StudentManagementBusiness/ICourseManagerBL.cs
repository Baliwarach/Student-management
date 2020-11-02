using StudentManagementBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementDAL;

namespace StudentManagementBusiness
{
    public interface ICourseManagerBL
    {
        void Save(Course course);
        List<Course> List();
        void Modify(Course course);
        void Delete(int id);
        Course Find(int id);
    }
}
