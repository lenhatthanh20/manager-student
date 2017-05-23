using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLSV3
{
    public partial class frmQuanLyNhom : Form
    {
        public frmQuanLyNhom()
        {
            InitializeComponent();
        }
        csThaoTac cs = new csThaoTac();   
        int hangDuocChon = 0; // biến này dùng để thao tác với table DataGridView, dùng chọn hàng!
  
        private void bNhap_Click(object sender, EventArgs e)// sự kiện click nút nhập!
        {
            //tạo 1 mảng lấy các giá trị từ các textbox chứa các data mới nhập, nhưng phải theo thứ tự các cột trong bảng DataGridView.
            String[] mang = { tHo.Text.Trim(), tTen.Text.Trim(), tMssv.Text.Trim(), tNgaySinh.Text.Trim(), tGioiTinh.Text.Trim(), cbMaNhom.Text.Trim() };
            dataQuanLyNhom.Rows.Clear();        //xóa toàn bộ bảng
            cs.LoadToDataGridView(dataQuanLyNhom, "Lop.txt");   //gọi hàm LoadToDataGridView từ class csThaoTac, nạp dữ liệu vào bảng từ file Lop.txt.
            dataQuanLyNhom.Rows.Add(mang);              //add các giá trị mới nhập vào hàng cuối của bảng.
            cs.WriteDataGridViewToFile(dataQuanLyNhom, "Lop.txt");  // gọi hàm WriteDataGridViewToFile để lưu lại trong file Lop.txt
            cbMaNhom_SelectedIndexChanged(sender, e); // lọc những data dựa vào mã nhóm.
        }

        private void cbMaNhom_SelectedIndexChanged(object sender, EventArgs e) // hàm lọc data dựa vào mã nhóm.
        {
            /* cho một vòng lặp chạy từ số hàng - 2 tới 0 (-2 là trừ hàng đầu tiên là đề mục.
             * so sánh mã nhóm trong bảng và mã nhóm trong combobox, nếu hàng nào khác thì remove hàng đó ra khỏi bảng nhưng không phải là xóa mất.
             * */
            dataQuanLyNhom.Rows.Clear();
            cs.LoadToDataGridView(dataQuanLyNhom, "Lop.txt");
            for (int i = dataQuanLyNhom.RowCount - 2; i >= 0; i--)
            {
                String a = dataQuanLyNhom[5, i].Value.ToString().ToLower().Trim(); // hàm ToLower() dùng để chuyển tất cả string sang chữ thường để tiện so sánh chuỗi.
                if (cbMaNhom.Text.ToLower().Trim() != a)
                {
                    dataQuanLyNhom.Rows.RemoveAt(i);
                }
            }
        }
        //----------------------------------------------------------------------------------------------------------//
        private void dataQuanLyNhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hangDuocChon = e.RowIndex;
            while (hangDuocChon < dataQuanLyNhom.RowCount - 1 && hangDuocChon >= 0)
            {
                tHo.Text = dataQuanLyNhom.Rows[hangDuocChon].Cells[0].Value.ToString();
                tTen.Text = dataQuanLyNhom.Rows[hangDuocChon].Cells[1].Value.ToString();
                tMssv.Text = dataQuanLyNhom.Rows[hangDuocChon].Cells[2].Value.ToString();
                tNgaySinh.Text = dataQuanLyNhom.Rows[hangDuocChon].Cells[3].Value.ToString();
                tGioiTinh.Text = dataQuanLyNhom.Rows[hangDuocChon].Cells[4].Value.ToString();
                cbMaNhom.Text = dataQuanLyNhom.Rows[hangDuocChon].Cells[5].Value.ToString();
                break;
            }
        
        }

       
        /* xử lý sự kiện click vào 1 hàng trong bảng thì các giá trị tự đổ vào các textbox và combobox để cho việc sửa thông tin.
         * bảng DataGridView cũng giống như 1 mảng 2 chiều nhưng là [chỉ số cột, chỉ số hàng], các chỉ số bắt đầu từ 0.
         * 
         * 
         * Không nên dùng CellContentClick mà nên dùng CellClick vì CellContentClick khi click vào nội dung (text) mới bắt được sự kiện.
         * nên sẽ có lúc bắt được click lúc không...... =.="
         * */
        private void bSua_Click(object sender, EventArgs e)
        {
            if (tHo.Text != "" && tTen.Text != "" && tMssv.Text != "" && tNgaySinh.Text != "" && tGioiTinh.Text != "" && cbMaNhom.Text != "")
            {

                dataQuanLyNhom.Rows.Clear();
                cs.LoadToDataGridView(dataQuanLyNhom, "Lop.txt");
                for (int i = 0; i < dataQuanLyNhom.RowCount - 1; ++i)
                {
                    if (tMssv.Text == dataQuanLyNhom[2, i].Value.ToString().Trim())
                    {
                        dataQuanLyNhom[0, i].Value = tHo.Text.Trim();
                        dataQuanLyNhom[1, i].Value = tTen.Text.Trim();
                        dataQuanLyNhom[3, i].Value = tNgaySinh.Text.Trim();
                        dataQuanLyNhom[4, i].Value = tGioiTinh.Text.Trim();
                        dataQuanLyNhom[5, i].Value = cbMaNhom.Text.Trim();
                    }
                }
                cs.WriteDataGridViewToFile(dataQuanLyNhom, "Lop.txt");
                cbMaNhom_SelectedIndexChanged(sender, e);
            }
        }

        private void bXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataQuanLyNhom.Rows.Clear();
                cs.LoadToDataGridView(dataQuanLyNhom, "Lop.txt");
                for (int i = 0; i < dataQuanLyNhom.RowCount - 1; ++i)
                {
                    if (tMssv.Text.ToLower().Trim() == dataQuanLyNhom[2, i].Value.ToString().ToLower().Trim())
                    {
                        dataQuanLyNhom.Rows.RemoveAt(i);
                    }
                cs.WriteDataGridViewToFile(dataQuanLyNhom, "Lop.txt");
                cbMaNhom_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void frmQuanLyNhom_Load(object sender, EventArgs e)
        {

        }
    }
}
