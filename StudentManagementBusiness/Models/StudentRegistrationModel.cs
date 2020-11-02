using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementDAL;
namespace StudentManagementBusiness.Models
{
    public class StudentRegistrationModel
    {
        public Student student { get; set; }
        public List<Course> selectedCourses { get; set; }

        public List<int> selectedCourseIDs { get; set; }

        public List<Course> AllCourses { get; set; }

        public List<Hostel> AllHostels { get; set; }

    }
}
