using System.Windows.Forms;

namespace GUI.PurchasedIngredient
{
    public partial class PurchasedList : Form
    {
        string _id;
        BaseForm _baseForm;
        public PurchasedList(string id, BaseForm @base)
        {
            InitializeComponent();
            _id = id;
            _baseForm = @base;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            DetailPurchaseedIngredient detail = new DetailPurchaseedIngredient(_id, _baseForm);
            detail.Location = new System.Drawing.Point(0, 0);
            detail.Show();
            this.SendToBack();
        }
    }
}
