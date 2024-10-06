using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class FoodUpdatedEventArgs : EventArgs
    {
        public string FoodId { get; set; }
        public string FoodName { get; set; }
        public string FoodPrice { get; set; }
        public int Quantity { get; set; }

        public FoodUpdatedEventArgs(string foodId, string foodName, string foodPrice, int quantity)
        {
            FoodId = foodId;
            FoodName = foodName;
            FoodPrice = foodPrice;
            Quantity = quantity;
        }
    }
}
