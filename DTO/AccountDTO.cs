using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        private string _id;
        private string _passwordHash;
        public string Id { get { return _id; } set { _id = value; } }
        public string PasswordHash { get { return _passwordHash; } set { _passwordHash = value; } }
    }
}
