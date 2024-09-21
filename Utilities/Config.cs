using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
