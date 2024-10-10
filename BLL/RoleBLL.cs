using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class RoleBLL
    {
        public List<string> GetOption(string employeeId)
        {
            return new RoleDAL().GetOption(employeeId);
        }
    }
}
