using System;
using System.Configuration;

namespace Utilities
{
    public static class SqlHelper
    {
        public static string GetConnectionString()
        {
            string deviceName = Environment.MachineName;

            var baseConnectionString = ConfigurationManager.ConnectionStrings["BaseConnectionString"].ConnectionString;
            var databaseName = ConfigurationManager.AppSettings["DatabaseName"];

            return baseConnectionString.Replace("Data Source=;", $"Data Source={deviceName}\\SQLEXPRESS;")
                                       .Replace("Initial Catalog=;", $"Initial Catalog={databaseName};");
        }
    }
}
