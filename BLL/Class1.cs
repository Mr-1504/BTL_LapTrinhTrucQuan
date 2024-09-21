using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Utilities;
namespace BLL
{
    public class Class1
    {
        public int IsExist(string userID)
        {
            return new FoodDAL().RemoveFood("CHI0003");
        }
        public DataTable GetData() {
            return new FoodDAL().GetFood(Food.FoodName, "Rau muống xào");
        }
    }
}
