using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FoodManagerBLL
    {
        FoodDAL foodDAL = new FoodDAL();
        public DataTable GetFoods()
        {
            return foodDAL.GetFoods();
        }
    }
}
