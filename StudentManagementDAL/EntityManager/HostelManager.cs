using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementDAL;

namespace StudentManagementDAL
{
    public class HostelManager : IEntityManager<Hostel>
    {
        StudentDBEntities db = new StudentDBEntities();
        public IQueryable<Hostel> FindAll()
        {
            return this.db.Hostels.Where(p => p.IsActive == true);
        }

        public Hostel Find(int id)
        {
            return this.db.Hostels.Find(id);
        }

        public void Save(Hostel hostel)
        {
            this.db.Hostels.Add(hostel);
            this.db.SaveChanges();
        }

        public void Modify(Hostel Hostel)
        {
            db.Entry(Hostel).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Hostel hostel = this.Find(id);
            db.Hostels.Remove(hostel);
            db.SaveChanges();
        }

        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}
