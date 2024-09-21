using System;
using System.ComponentModel;
using System.Reflection;

namespace Utilities
{
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

    public enum Gender
    {
        [Description("Nam")]
        Male,

        [Description("Nữ")]
        Female,

        [Description("Khác")]
        Other
    }

    public static class Config
    {
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
    }
}
