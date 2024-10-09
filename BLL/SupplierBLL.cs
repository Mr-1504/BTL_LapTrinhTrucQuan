using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;
using Utilities;
namespace BLL
{
    public class SupplierBLL
    {
        public List<SupplierDTO> GetSuppliers(string search = "")
        {
            DataTable data = search == "" ? new SupplierDAL().GetSuppliers() : new SupplierDAL().GetSuppliers(search);
            List<SupplierDTO> suppliers = new List<SupplierDTO>();
            foreach (DataRow row in data.Rows)
            {
                if (row != null)
                {
                    suppliers.Add(new SupplierDTO(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), Status.Use));
                }
            }
            return suppliers;
        }

        public int IsExist(string value)
        {
            return new SupplierDAL().IsExist(value);
        }
        public SupplierDTO GetSupplierByName(string name)
        {
            DataTable data = new SupplierDAL().GetSupplierByName(name);
            return new SupplierDTO(data.Rows[0][0].ToString(), data.Rows[0][1].ToString(), data.Rows[0][2].ToString(), data.Rows[0][3].ToString(), Status.Use);
        }
        public SupplierDTO GetSupplierById(string id)
        {
            DataTable data = new SupplierDAL().GetSupplierById(id);
            return new SupplierDTO(data.Rows[0][0].ToString(), data.Rows[0][1].ToString(), data.Rows[0][2].ToString(), data.Rows[0][3].ToString(), Status.Use);

        }
    }
}
