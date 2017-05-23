using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace QLSV3
{
    public partial class frmGiaoDien : Form
    {
        public frmGiaoDien()
        {
            InitializeComponent();
        }

        public static bool kiemTra;

        private void frmGiaoDien_Load(object sender, EventArgs e)
        {
            if (kiemTra) //biến kiemTra là true từ bên form đăng nhập đưa qua thì....
            {
                mnDangNhap.Enabled = false; // đây là các thuộc tính trong menuStrip
                mnDangXuat.Enabled = true;   // bằng true nghĩa là cho phép sử dụng, false ngược lại 
                mnThoat.Enabled = true;
                mnNhom.Enabled = true;
                mnDiem.Enabled = true;
                mnThongKe.Enabled = true;
            }
        }

        private void mnDangXuat_Click(object sender, EventArgs e) //sự kiện click đăng xuất 
        {
            mnDangNhap.Enabled = true;              //khi đăng xuất thì cấm các thuộc tính hoạt động trừ thoát và đăng nhập!
            mnDangXuat.Enabled = false;
            mnThoat.Enabled = true;
            mnNhom.Enabled = false;
            mnDiem.Enabled = false;
            mnThongKe.Enabled = false;
            MessageBox.Show("Đăng xuất thành công!");
        }

        private void mnThoat_Click(object sender, EventArgs e) // sự kiện click thoát.
        {
            Application.Exit();
        }

        private void mnDangNhap_Click(object sender, EventArgs e)   // sự kiện click đăng nhập sau khi đã đăng xuất
        {
            Hide();                                                   //ẩn form hiện tại (form giao diện)
            new frmDangNhap().ShowDialog();                     // mở lại form đăng nhập đã tắt.

        }

        private void mnNhom_Click(object sender, EventArgs e) // sự kiện click nhóm
        {
            new frmQuanLyNhom().ShowDialog();                 // hiện form quản lý nhóm
        }

        private void mnDiem_Click(object sender, EventArgs e)  // sự kiện click điểm
        {
            new frmQuanLyDiem().ShowDialog();                   // hiện form quản lý điểm
        }

        private void mnThongKe_Click(object sender, EventArgs e)
        {
            new frmTongKet().ShowDialog();
        } 
    }
}
