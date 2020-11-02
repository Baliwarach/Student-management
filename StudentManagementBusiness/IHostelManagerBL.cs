using StudentManagementBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementDAL;

namespace StudentManagementBusiness
{
    public interface IHostelManagerBL
    {
        void Save(Hostel hostel);
        List<Hostel> List();
        void Modify(Hostel hostel);
        void Delete(int id);
        Hostel Find(int id);
    }
}
