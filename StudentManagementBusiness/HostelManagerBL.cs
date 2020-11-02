using StudentManagementBusiness.Models;
using StudentManagementDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementBusiness
{
    public class HostelManagerBL : IHostelManagerBL
    {
        private HostelManager hostelManager;
        public HostelManagerBL()
        {
            hostelManager = new HostelManager();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Hostel Find(int id)
        {
            return hostelManager.Find(id);
        }

        public List<Hostel> List()
        {
            return hostelManager.FindAll().ToList();
        }

        public void Modify(Hostel course)
        {
            throw new NotImplementedException();
        }

        public void Save(Hostel course)
        {
            throw new NotImplementedException();
        }
    }
}
