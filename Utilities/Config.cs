﻿using System;
using System.ComponentModel;
using System.Reflection;

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
        Warehouse,

        [Description("AD")]
        Admin
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

        public static bool IsValidEnum<TEnum>(string value) where TEnum : struct, Enum
        {
            return Enum.IsDefined(typeof(TEnum), value) && Enum.TryParse<TEnum>(value, true, out var _);
        }
    }
}
