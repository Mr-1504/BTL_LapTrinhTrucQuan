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
        public PurchaseInvoiceDTO GetNewestPurchaseInvoice()
        {
            DataTable data = new PurchaseInvoiceDAL().GetNewestPurchaseInvoice();
            DateTime date = new DateTime();
            try
            {
                date = DateTime.Parse(data.Rows[0][3].ToString());
            }
            catch (Exception ex) { }
            return new PurchaseInvoiceDTO(data.Rows[0][0].ToString(), data.Rows[0][1].ToString(), data.Rows[0][2].ToString(), date);
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
    }
}
