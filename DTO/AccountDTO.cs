﻿namespace DTO
{
    public class AccountDTO
    {
        private string _id;
        private string _passwordHash;
        public string Id { get { return _id; } set { _id = value; } }
        public string PasswordHash { get { return _passwordHash; } set { _passwordHash = value; } }
        public AccountDTO(string employeeId, string hashedPassword)
        {
            Id = employeeId;
            PasswordHash = hashedPassword;
        }
    }
}
