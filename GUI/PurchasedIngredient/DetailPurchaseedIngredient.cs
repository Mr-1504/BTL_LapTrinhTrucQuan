using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.PurchasedIngredient
{
    public partial class DetailPurchaseedIngredient : Form
    {
        private InputDetail inputDetail;
        public DetailPurchaseedIngredient()
        {
            InitializeComponent();
            inputDetail = new InputDetail();

            inputDetail.Location = new Point(0, 90);
            Controls.Add(inputDetail);
        }
    }
}
