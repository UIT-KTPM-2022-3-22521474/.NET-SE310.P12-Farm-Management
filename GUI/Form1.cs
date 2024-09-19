using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class Form1 : Form
    {
        private FarmBLL farmBLL;

        public Form1()
        {
            InitializeComponent();
            farmBLL = new FarmBLL(); // Khởi tạo đối tượng FarmBLL
        }

        // Xử lý sự kiện nút Thêm Gia Súc
        private void btnThemGiaSuc_Click(object sender, EventArgs e)
        {
            try
            {
                int soLuongBo = int.Parse(txtSoLuongBo.Text);
                int soLuongCuu = int.Parse(txtSoLuongCuu.Text);
                int soLuongDe = int.Parse(txtSoLuongDe.Text);

                // Thêm Bò
                for (int i = 0; i < soLuongBo; i++)
                {
                    farmBLL.ThemGiaSuc(new Bo());
                }

                // Thêm Cừu
                for (int i = 0; i < soLuongCuu; i++)
                {
                    farmBLL.ThemGiaSuc(new Cuu());
                }

                // Thêm Dê
                for (int i = 0; i < soLuongDe; i++)
                {
                    farmBLL.ThemGiaSuc(new De());
                }

                lblThongTin.Text = $"Đã thêm {soLuongBo} bò, {soLuongCuu} cừu, {soLuongDe} dê.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho số lượng gia súc.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện nút Kêu Tiếng
        private void btnKeuTieng_Click(object sender, EventArgs e)
        {
            string tiengKeu = farmBLL.TiengKeu();
            MessageBox.Show(tiengKeu, "Tiếng kêu của gia súc", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Xử lý sự kiện nút Thống Kê
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int tongSoGiaSuc = farmBLL.TongSoGiaSuc();
            int tongSoLitSua = farmBLL.TongSoLitSua();

            string thongKe = $"Tổng số gia súc: {tongSoGiaSuc}\nTổng số lít sữa: {tongSoLitSua}";
            MessageBox.Show(thongKe, "Thống kê trang trại", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSinhCon_Click(object sender, EventArgs e)
        {
            // Gọi phương thức SinhCon của FarmBLL
            farmBLL.SinhCon();

            // Hiển thị thông báo sau khi sinh con
            MessageBox.Show("Gia súc đã sinh con thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cập nhật thông tin sau khi sinh con
            int tongSoGiaSuc = farmBLL.TongSoGiaSuc();
            int tongSoLitSua = farmBLL.TongSoLitSua();
            lblThongTin.Text = $"Tổng số gia súc: {tongSoGiaSuc}";
        }


        // Xử lý sự kiện nút Xóa Tất Cả
        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            farmBLL = new FarmBLL(); // Tạo mới đối tượng BLL để xóa tất cả gia súc
            lblThongTin.Text = "Đã xóa tất cả gia súc.";
        }
    }
}
