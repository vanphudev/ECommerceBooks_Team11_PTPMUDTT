using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_ECommerceBooks.UIBanHang
{
    public partial class UC_GioHang : UserControl
    {
        private List<Product> cartItems = new List<Product>(); // Danh sách sản phẩm trong giỏ hàng

        public UC_GioHang()
        {
            InitializeComponent();
            InitDataGridView();
        }

        private void InitDataGridView()
        {
            // Cấu hình các cột cho DataGridView
            dataGridView1.Columns.Add("TenSach", "Tên sách");
            dataGridView1.Columns.Add("NhaXuatBan", "Nhà xuất bản");
            dataGridView1.Columns.Add("SoLuong", "Số lượng");
            dataGridView1.Columns.Add("Gia", "Giá");
            dataGridView1.Columns.Add("ThanhTien", "Thành tiền");
        }

        // Phương thức thêm sản phẩm vào giỏ hàng
        public void AddProductToCart(Product product)
        {
            cartItems.Add(product); // Thêm sản phẩm vào danh sách

            // Hiển thị trên DataGridView
            dataGridView1.Rows.Add(product.TenSach, product.NhaXuatBan, product.SoLuong, product.Gia, product.ThanhTien);

            // Cập nhật tổng tiền
            TinhTongTien();
        }

        // Phương thức tính tổng tiền giỏ hàng
        private void TinhTongTien()
        {
            decimal total = 0;
            foreach (var item in cartItems)
            {
                total += item.ThanhTien;
            }
            txtTongTien.Text = total.ToString("N0"); // Hiển thị tổng tiền dưới dạng số
        }
    }
}
