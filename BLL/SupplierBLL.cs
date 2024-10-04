using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;
using Utilities;
namespace BLL
{
    public class SupplierBLL
    {
        public List<SupplierDTO> GetSuppliers()
        {
            List<SupplierDTO> suppliers = new List<SupplierDTO>();
            DataTable data = new SupplierDAL().GetSuppliers();
            foreach (DataRow row in data.Rows)
            {
                if (row != null)
                {
                    suppliers.Add(new SupplierDTO(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), Status.Use));
                }
            }
            return suppliers;
        }
    }
}
