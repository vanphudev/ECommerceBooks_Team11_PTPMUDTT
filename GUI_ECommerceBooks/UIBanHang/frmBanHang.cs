using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace GUI_ECommerceBooks.UIBanHang
{
    public partial class frmBanHang : DevExpress.XtraEditors.XtraForm
    {
        public frmBanHang()
        {
            InitializeComponent();
            uC_ChiTietSanPham1.ProductAdded += UC_ChiTietSanPham1_ProductAdded;
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void UC_ChiTietSanPham1_ProductAdded(object sender, ProductEventArgs e)
        {
            uC_GioHang1.AddProductToCart(e.Product);
            MessageBox.Show("Đã thêm sản phẩm vào giỏ hàng!");
        }
    }
}