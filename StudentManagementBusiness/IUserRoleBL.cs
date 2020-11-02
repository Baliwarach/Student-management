using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementDAL;

namespace StudentManagementBusiness
{
    public interface IUserRoleBL
    {        
        string GetRoleForUser(string username);
    }
}
