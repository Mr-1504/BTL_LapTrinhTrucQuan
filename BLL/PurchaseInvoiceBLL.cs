using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using Utilities;

namespace BLL
{
    public class PurchaseInvoiceBLL
    {
        public DataTable GetPurchaseInvoiceDetail(string invoiceId)
        {
            DataTable data = new PurchaseInvoiceDetailDAL().GetPurchaseInvoiceDetails(invoiceId);
            DataTable list = new DataTable();
            list.Columns.Add("Name");
            list.Columns.Add("Unit");
            list.Columns.Add("Quantity");
            list.Columns.Add("PriceUnit");
            foreach(DataRow row in data.Rows)
            {
                string id = row[1].ToString();
                IngredientDTO ingredient = new IngredientBLL().GetIngredient(Ingredient.IngredientId, id)[0];
                list.Rows.Add(ingredient.IngredientName, ingredient.IngredientUnit.GetEnumDescription(), row[2].ToString(), row[3].ToString());
            }
            return list;
        }
        public List<PurchaseInvoiceDTO> GetInvoices()
        {
            DataTable dt = new PurchaseInvoiceDAL().GetPurchaseInvoiceTable();
            List<PurchaseInvoiceDTO> invoices = new List<PurchaseInvoiceDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                DateTime date = new DateTime();
                decimal total = 0;
                try
                {
                    date = DateTime.Parse(dr[3].ToString());

                }
                catch (Exception ex) { }
                try
                {
                    total = decimal.Parse(dr[4].ToString());
                }
                catch { }
                invoices.Add(new PurchaseInvoiceDTO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), date, total));
            }
            return invoices;
        }
        public PurchaseInvoiceDTO GetNewestPurchaseInvoice()
        {
            DataTable data = new PurchaseInvoiceDAL().GetNewestPurchaseInvoice();
            DateTime date = new DateTime();
            decimal total = 0;
            try
            {
                date = DateTime.Parse(data.Rows[0][3].ToString());
            }
            catch (Exception ex) { }
            try
            {
                total = decimal.Parse(data.Rows[0][4].ToString());
            }
            catch { }
            return new PurchaseInvoiceDTO(data.Rows[0][0].ToString(), data.Rows[0][1].ToString(), data.Rows[0][2].ToString(), date, total);
        }


        public int AddNewPurchaseInvoice(PurchaseInvoiceDTO invoice, List<PurchaseInvoiceDetailDTO> invoiceDetail)
        {
            int res = new PurchaseInvoiceDAL().AddNewPurchaseInvoice(invoice);
            if (res == 1)
            {
                PurchaseInvoiceDetailDAL detailDAL = new PurchaseInvoiceDetailDAL();
                IngredientDAL ingredientDAL = new IngredientDAL();
                IngredientBLL ingredientBLL = new IngredientBLL();
                PurchaseInvoiceDTO newest = GetNewestPurchaseInvoice();

                for (int i = 0; i < invoiceDetail.Count; i++)
                {
                    invoiceDetail[i].PurchaseInvoiceId = newest.PurchaseInvoiceId;
                    int temp = detailDAL.AddNewPurchaseInvoiceDetail(invoiceDetail[i]);
                    if (temp != 1)
                    {
                        RollBack(i, newest, invoiceDetail);
                        return 0;
                    }
                    IngredientDTO ingredient = ingredientBLL.GetIngredient(Ingredient.IngredientId, invoiceDetail[i].IngredientId)[0];
                    ingredient.IngredientQuantity = ingredient.IngredientQuantity >= 0 ?
                        ingredient.IngredientQuantity + invoiceDetail[i].Quantity : invoiceDetail[i].Quantity;
                    temp = ingredientDAL.UpdateIngredient(ingredient);
                    if (temp != 1)
                    {
                        RollBack(i, newest, invoiceDetail);
                        return 0;
                    }
                }
            }
            return res;
        }

        private void RollBack(int j, PurchaseInvoiceDTO newest, List<PurchaseInvoiceDetailDTO> invoiceDetail)
        {
            new PurchaseInvoiceDetailDAL().RemovePurchaseInvoiceDetail(newest.PurchaseInvoiceId);
            new PurchaseInvoiceDAL().RemovePurchaseInvoice(newest.PurchaseInvoiceId);
            for (int i = 0; i < j; i++)
            {
                IngredientDTO ingredient = new IngredientBLL().GetIngredient(Ingredient.IngredientId, invoiceDetail[i].IngredientId)[0];
                ingredient.IngredientQuantity -= invoiceDetail[i].Quantity;
                new IngredientDAL().UpdateIngredient(ingredient);
            }
        }
        public string ReadNumberToWords(decimal amount)
        {
            if (amount == 0) return "không đồng";

            long wholePart = (long)amount;
            int decimalPart = (int)((amount - wholePart) * 100);

            string result = ReadWholeNumberToWords(wholePart);
            if (decimalPart > 0)
            {
                result += " và " + ReadWholeNumberToWords(decimalPart) + " xu";
            }

            return result.Trim() + " đồng";
        }

        private static string ReadWholeNumberToWords(long amount)
        {
            string[] numberWords = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] unitNames = { "", "nghìn", "triệu", "tỷ" };

            string result = "";
            int unitPosition = 0;

            while (amount > 0)
            {
                long threeDigitNumber = amount % 1000; 
                amount /= 1000;  
                string threeDigitsWords = ReadThreeDigitsToWords(threeDigitNumber, numberWords, unitPosition > 0);

                if (!string.IsNullOrEmpty(threeDigitsWords))
                {
                    result = threeDigitsWords + " " + unitNames[unitPosition] + " " + result;
                }

                unitPosition++;
            }

            return result.Trim();
        }

        private static string ReadThreeDigitsToWords(long number, string[] numberWords, bool isHigherUnit)
        {
            int hundreds = (int)(number / 100);
            int tens = (int)((number % 100) / 10);
            int ones = (int)(number % 10);

            string result = "";

            if (hundreds > 0)
            {
                result += numberWords[hundreds] + " trăm";
            }
            else if (number > 0 && !isHigherUnit)
            {
                result += "không trăm";
            }

            if (tens > 0)
            {
                result += " " + numberWords[tens] + " mươi";
            }
            else if (ones > 0 && hundreds > 0)
            {
                result += " linh";
            }

            if (ones > 0)
            {
                if (ones == 5 && tens > 0)
                {
                    result += " lăm";
                }
                else
                {
                    result += " " + numberWords[ones];
                }
            }

            return result.Trim();
        }

    }
}
