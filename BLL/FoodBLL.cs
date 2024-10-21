using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace BLL
{
    public class FoodBLL
    {
        private FoodDAL _foodDAL = new FoodDAL();

        public List<FoodDTO> GetListFoods()
        {
            var dt = _foodDAL.GetFoods();
            var foods = new List<FoodDTO>();

            foreach (DataRow row in dt.Rows)
            {
                var food = new FoodDTO(
                    row["MaMonAn"].ToString(),      
                    row["TenMonAn"].ToString(),    
                    row["CachLam"].ToString(),      
                    Convert.ToInt32(row["DonGia"]), 
                    (Status)Convert.ToInt32(row["TrangThai"]) 
                );

                foods.Add(food);
            }
            return foods;
        }

        public string GetFoodIdByName(string nameFood)
        {
            return _foodDAL.GetFoodIdByName(nameFood);
        }
    }
}
