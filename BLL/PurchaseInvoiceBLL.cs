using DAL;
using DTO;
using System;
using System.Data;

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
            }catch (Exception ex) { }
            return new PurchaseInvoiceDTO(data.Rows[0][0].ToString(), data.Rows[0][1].ToString(), data.Rows[0][2].ToString(), date);
        }

        public int AddNewPurchaseInvoice(PurchaseInvoiceDTO invoice)
        {
            return new PurchaseInvoiceDAL().AddNewPurchaseInvoice(invoice);
        }
    }
}
