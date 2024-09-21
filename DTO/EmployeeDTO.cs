using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmployeeDTO
    {
        private string _id;
        private string _name;
        private int _gender;
        private DateTime _birth;
        private string _hometown;
        private string _address;

        public string ID { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Gender { get => _gender; set => _gender = value; }
        public DateTime Birth { get => _birth; set => _birth = value; }
        public string Hometown { get => _hometown; set => _hometown = value; }
        public string Address { get => _address; set => _address = value; }

        public EmployeeDTO(string id = "", string name = "", int gender = -1, DateTime birth = default(DateTime), string hometown = "", string address = "")
        {
            _id = id;
            _name = name;
            _gender = gender;
            _birth = birth;
            _hometown = hometown;
        }
    }
}
