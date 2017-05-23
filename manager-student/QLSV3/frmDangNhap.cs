using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/* form đăng nhập này là 1 form đơn giản */
namespace QLSV3
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void bThoat_Click(object sender, EventArgs e) //sự kiện Click vào nút thoát
        {
            Application.Exit();                                 // thoát toàn bộ ứng dụng!
        }

        private void bDangNhap_Click(object sender, EventArgs e) // sự kiện click nút đăng nhập
        {
            String taiKhoan = "a";                          //tạo thẳng biến tài khoản là: admin
            String matKhau = "a";                           //tạo thẳng biến mật khẩu là: admin
            if (taiKhoan == tMatKhau.Text.Trim() && matKhau == tTaiKhoan.Text.Trim()) 
                //nếu người dùng đăng nhập đúng tài khoản và mật khẩu trên thì đăng nhập thành công, ở đây có phân biệt chữ hoa và chữ thường.
            {
                this.Hide();                        // form hiện tại (form đăng nhập) được ẩn đi.   
                MessageBox.Show("Đăng nhập thành công!");   // Hiện thông báo đăng nhập thành công.
                frmGiaoDien.kiemTra = true;                 //biến toàn cục kiemTra này có giá trị là true để xử lý sự kiện bên form giao diện.
                frmGiaoDien frm0 = new frmGiaoDien();       // mở form giao diện.
                frm0.ShowDialog();
                Close();                                    //tắt form đăng nhập.
            }
            else if(taiKhoan != tMatKhau.Text.Trim() || matKhau != tTaiKhoan.Text.Trim())
                //nếu đăng nhập sai thông tin thì yêu cầu đăng nhập lại.
            {
                MessageBox.Show("Đăng nhập sai thông tin!");
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
