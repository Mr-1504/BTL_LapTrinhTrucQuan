using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.PurchasedIngredient
{
    public partial class InvoiceDtail : UserControl
    {
        public InvoiceDtail(PurchaseInvoiceDTO invoice, List<PurchaseInvoiceDetailDTO> invoiceDetail)
        {
            InitializeComponent();
            lblCreateionTime.Text = invoice.DateOfPurchase.ToString("HH:mm:ss dd/MM/yyyy");
           // lblEmployeeInformation.Text = 
        }
    }
}
