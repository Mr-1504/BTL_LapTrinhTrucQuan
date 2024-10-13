using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public static class SharedDataTable
    {
        public static DataTable FoodItems { get; set; } = new DataTable();
    }
}
