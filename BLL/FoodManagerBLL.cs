using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace BLL
{
    public class FoodManagerBLL
    {
        FoodDAL foodDAL = new FoodDAL();
        public DataTable GetFoods()
        {
            return foodDAL.GetFoods();
        }
        public int ChangeFoodStatus(string foodId, Status status)
        {
            return foodDAL.ChangeFoodStatus(foodId, status);
        }
        public DataTable GetFoods(Food @enum, string getValue)
        {
            return foodDAL.GetFood(@enum, getValue);
        }
    }
}
