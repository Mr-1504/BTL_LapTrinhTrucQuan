using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Windows.Forms;


namespace Utilities
{
    
    public enum Status
    {
        NoUse,
        Use
    }
    public enum FoodType
    {
        [Description("AP")]
        Appetizer,

        [Description("MN")]
        MainCourse,

        [Description("DS")]
        Dessert
    }

    public enum EmployeeType
    {
        [Description("LT")]
        Receptionist,

        [Description("QL")]
        Manager,

        [Description("KH")]
        Warehouse
    }

    public enum SupplierType
    {
        [Description("TH")]
        Meat,

        [Description("RA")]
        Vegetable,

        [Description("GA")]
        Spice,

        [Description("HA")]
        Seafood,

        [Description("DA")]
        DryFood
    }
    public enum Employee
    {
        [Description("MaNhanVien")]
        EmployeeId,

        [Description("TenNhanVien")]
        Name,

        [Description("GioiTinh")]
        Gender,

        [Description("NamSinh")]
        Birthday,

        [Description("QueQuan")]
        Hometown,

        [Description("DiaChi")]
        Address,

        [Description("DienThoai")]
        NumberPhone
    }

    public enum EmployeeStatus
    {
        [Description("Đã nghỉ hưu")]
        Retired,

        [Description("Đã nghỉ việc")]
        NoLongerWorking,

        [Description("Đang làm việc")]
        CurrentlyWorking
    }

    public enum Gender
    {
        [Description("Nam")]
        Male,

        [Description("Nữ")]
        Female,

        [Description("Khác")]
        Other
    }

    public enum Food
    {
        [Description("MaMonAn")]
        FoodId,

        [Description("TenMonAn")]
        FoodName,

        [Description("CachLam")]
        FoodMaking,

        [Description("DonGia")]
        FoodUnitPrice
    }

    public enum Ingredient
    {
        [Description("MaNguyenLieu")]
        IngredientId,

        [Description("TenNguyenLieu")]
        IngredientName,

        [Description("DonViTinh")]
        IngredientUnit,
    }
    public enum Unit
    {
        Kg,
        Gram
    }

    public enum Order
    {
        [Description("Đã thanh toán")]
        paid,

        [Description("Chưa thanh toán")]
        unpaid
    }

    public enum Recipe
    {
        [Description("MaMonAn")]
        FoodId,

        [Description("MaNguyenLieu")]
        Ingredient,

        Orther
    }
    public static class Config
    {
        public static readonly string PROJECT_PATH = System.IO.Directory.GetParent(System.IO.Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName).FullName;
        public static readonly string BLUE = "#2D60FF";
        public static readonly string GRAY = "#B1B1B1";

        public static string GetEnumDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            if (field != null)
            {
                DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (attribute != null)
                {
                    return attribute.Description;
                }
            }
            return value.ToString();
        }
        public static T GetEnumValueFromDescription<T>(string description) where T : Enum
        {
            foreach (var field in typeof(T).GetFields())
            {
                var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
                if (attribute != null && attribute.Description == description)
                {
                    return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException($"No enum value found for description '{description}'", nameof(description));
        }
        public static bool IsValidEnum<TEnum>(string value) where TEnum : struct, Enum
        {
            return Enum.IsDefined(typeof(TEnum), value) && Enum.TryParse<TEnum>(value, true, out var _);
        }
        public static T GetEnumValueFromName<T>(string name) where T : struct, Enum
        {
            if (Enum.TryParse<T>(name, out var result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException($"Không tìm thấy giá trị enum cho tên '{name}'", nameof(name));
            }
        }
        public static bool IsSystemInDarkMode()
        {
            var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize");
            if (key != null)
            {
                var value = key.GetValue("AppsUseLightTheme");
                if (value != null && (int)value == 0)
                {
                    return true; // Dark mode
                }
            }
            return false; // Light mode
        }

        public static DataTable ConvertToDataTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                dt.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                DataRow newRow = dt.NewRow();

                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    newRow[i] = row.Cells[i].Value;
                }

                dt.Rows.Add(newRow);
            }
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row.ToString());
            }
            return dt;
        }
    }
}
