using System.Collections.Generic;
using System.Data;
using System.Linq;
using Utilities;

namespace DAL
{
    public class RoleDAL
    {
        public List<string> GetOption(string employeeId)
        {
            string role = employeeId.Substring(0, 2);
            string query = "SELECT * FROM QuyenTruyCap WHERE ChucVu = @role";
            return SqlHelper.ExecuteReader(query, new object[] { role }).AsEnumerable()
                .Select(row => row.Field<string>("Menu")).ToList();
        }
    }
}
