using System;
using Utilities;

namespace DTO
{
    public class EmployeeDTO
    {
        private string _employeeId;
        private string _name;
        private Gender _gender;
        private DateTime _birth;
        private string _hometown;
        private string _address;
        private string _numberPhone;

        public string Name { get => _name; set => _name = value; }
        public Gender Gender { get => _gender; set => _gender = value; }
        public DateTime Birth { get => _birth; set => _birth = value; }
        public string Hometown { get => _hometown; set => _hometown = value; }
        public string Address { get => _address; set => _address = value; }
        public string EmployeeId { get => _employeeId; set => _employeeId = value; }
        public string NumberPhone { get => _numberPhone; set => _numberPhone = value; }

        public EmployeeDTO(string id = "", string name = "", Gender gender = Gender.Other, DateTime birth = default(DateTime), string hometown = "", string address = "", string numberPhone = "")
        {
            EmployeeId = id;
            Name = name;
            Gender = gender;
            Birth = birth;
            Hometown = hometown;
            NumberPhone = numberPhone;
            Address = address;
        }
    }
}
