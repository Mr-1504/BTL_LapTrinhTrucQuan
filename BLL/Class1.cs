using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class Class1
    {
        public int IsExist(string userID)
        {
            return new AccountDAL().RemoveAccount("QL0001");
        }
    }
}
