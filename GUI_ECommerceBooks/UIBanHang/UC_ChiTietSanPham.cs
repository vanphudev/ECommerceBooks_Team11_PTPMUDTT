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
    public partial class UC_ChiTietSanPham : UserControl
    {
        public UC_ChiTietSanPham()
        {
            InitializeComponent();
            btn_ThemGioHang.Click += Btn_ThemGioHang_Click;
        }

        // Tạo sự kiện để truyền sản phẩm ra ngoài
        public event EventHandler<ProductEventArgs> ProductAdded;

        private void Btn_ThemGioHang_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng Product để lưu trữ thông tin
            Product product = new Product
            {
                TenSach = txt_TenSach.Text,
                NhaXuatBan = textBox1.Text,
                SoLuong = (int)num_SoLuong.Value,
                Gia = decimal.Parse(txtGiaTien.Text),
                ThanhTien = decimal.Parse(txtGiaTien.Text) * (int)num_SoLuong.Value
            };

            ProductAdded?.Invoke(this, new ProductEventArgs { Product = product });
        }

        public void DisplayBookDetails(Product book)
        {
            txt_TenSach.Text = book.TenSach;
            textBox1.Text = book.NhaXuatBan; // Nhà xuất bản
            txtGiaTien.Text = book.Gia.ToString();
            num_SoLuong.Value = book.SoLuong;
            txtTongTien.Text = (book.Gia * book.SoLuong).ToString();
        }
    }

    // Đối tượng Product dùng để chứa thông tin sách
    public class Product
    {
        public string TenSach { get; set; }
        public string NhaXuatBan { get; set; }
        public int SoLuong { get; set; }
        public decimal Gia { get; set; }
        public decimal ThanhTien { get; set; }
    }

    // Lớp chứa thông tin sự kiện
    public class ProductEventArgs : EventArgs
    {
        public Product Product { get; set; }
    }
}
