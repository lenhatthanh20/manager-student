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
    public partial class frmQuanLyDiem : Form
    {
        public frmQuanLyDiem()
        {
            InitializeComponent();
        }
        csThaoTac cs = new csThaoTac();
        int hangDuocChon = 0;
        //-------------------------------------------------------------------------
        private void cbChonNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cs.LoadToDataGridView(dataGridView1, "Diem.txt");
            for (int i = dataGridView1.RowCount - 2; i >= 0; i--)
            {
                String a = dataGridView1[0, i].Value.ToString().ToLower().Trim(); // hàm ToLower() dùng để chuyển tất cả string sang chữ thường để tiện so sánh chuỗi.
                if (cbChonNhom.Text.ToLower().Trim() != a)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
        }
        //----------------------------------------------------------------
        private void tTuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cs.LoadToDataGridView(dataGridView1, "Diem.txt");
            for (int i = dataGridView1.RowCount - 2; i >= 0; i--)
            {
                String a = dataGridView1[1, i].Value.ToString().ToLower().Trim(); // hàm ToLower() dùng để chuyển tất cả string sang chữ thường để tiện so sánh chuỗi.
                if (tTuan.Text.ToLower().Trim() != a)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
        }
        //----------------------------------------------------------------
        private void bNhap_Click(object sender, EventArgs e)
        {
            double diemTongKetTuan = 0;
            diemTongKetTuan = (((double.Parse(tDiemNhom1.Text) + double.Parse(tDiemNhom2.Text) + double.Parse(tDiemNhom3.Text)
                + double.Parse(tDiemNhom4.Text) + double.Parse(tDiemNhom5.Text) + double.Parse(tDiemNhom6.Text) + double.Parse(tDiemNhom7.Text)
                + double.Parse(tDiemNhom8.Text) + double.Parse(tDiemNhom9.Text)) / 8) + double.Parse(tDiemThay.Text))/2;
            String[] mang = { cbChonNhom.Text.Trim(), tTuan.Text.Trim(), tDiemThay.Text.Trim(), tDiemNhom1.Text.Trim(), 
                                tDiemNhom2.Text.Trim(), tDiemNhom3.Text.Trim(), tDiemNhom4.Text.Trim(), tDiemNhom5.Text.Trim(), 
                                tDiemNhom6.Text.Trim(), tDiemNhom7.Text.Trim(), tDiemNhom8.Text.Trim(), tDiemNhom9.Text.Trim(), diemTongKetTuan.ToString()};
            dataGridView1.Rows.Clear();
            cs.LoadToDataGridView(dataGridView1, "Diem.txt");
            dataGridView1.Rows.Add(mang);
            cs.WriteDataGridViewToFile(dataGridView1, "Diem.txt");
            cbChonNhom_SelectedIndexChanged(sender, e);
        }
        //------------------------------------------------------------------------------
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hangDuocChon = e.RowIndex;
            while (hangDuocChon < dataGridView1.RowCount - 1 && hangDuocChon >= 0)
            {
                tDiemThay.Text = dataGridView1.Rows[hangDuocChon].Cells[2].Value.ToString();
                tDiemNhom1.Text = dataGridView1.Rows[hangDuocChon].Cells[3].Value.ToString();
                tDiemNhom2.Text = dataGridView1.Rows[hangDuocChon].Cells[4].Value.ToString();
                tDiemNhom3.Text = dataGridView1.Rows[hangDuocChon].Cells[5].Value.ToString();
                tDiemNhom4.Text = dataGridView1.Rows[hangDuocChon].Cells[6].Value.ToString();
                tDiemNhom5.Text = dataGridView1.Rows[hangDuocChon].Cells[7].Value.ToString();
                tDiemNhom6.Text = dataGridView1.Rows[hangDuocChon].Cells[8].Value.ToString();
                tDiemNhom7.Text = dataGridView1.Rows[hangDuocChon].Cells[9].Value.ToString();
                tDiemNhom8.Text = dataGridView1.Rows[hangDuocChon].Cells[10].Value.ToString();
                tDiemNhom9.Text = dataGridView1.Rows[hangDuocChon].Cells[11].Value.ToString();
                break;
            }
        }

        private void bSua_Click(object sender, EventArgs e)
        {
            if (cbChonNhom.Text != "" && tDiemNhom1.Text != "" && tDiemNhom2.Text != ""
                && tDiemNhom3.Text != "" && tDiemNhom4.Text != "" && tDiemNhom5.Text != "" && tDiemNhom6.Text != ""
                && tDiemNhom7.Text != "" && tDiemNhom8.Text != "" && tDiemNhom9.Text != "" && tDiemThay.Text != "")
            {
                dataGridView1.Rows.Clear();
                cs.LoadToDataGridView(dataGridView1, "Diem.txt");
                {
                        dataGridView1[2, hangDuocChon].Value = tDiemThay.Text.Trim();
                        dataGridView1[3, hangDuocChon].Value = tDiemNhom1.Text.Trim();
                        dataGridView1[4, hangDuocChon].Value = tDiemNhom2.Text.Trim();
                        dataGridView1[5, hangDuocChon].Value = tDiemNhom3.Text.Trim();
                        dataGridView1[6, hangDuocChon].Value = tDiemNhom4.Text.Trim();
                        dataGridView1[7, hangDuocChon].Value = tDiemNhom5.Text.Trim();
                        dataGridView1[8, hangDuocChon].Value = tDiemNhom6.Text.Trim();
                        dataGridView1[9, hangDuocChon].Value = tDiemNhom7.Text.Trim();
                        dataGridView1[10, hangDuocChon].Value = tDiemNhom8.Text.Trim();
                        dataGridView1[11, hangDuocChon].Value = tDiemNhom9.Text.Trim();
                }
                cs.WriteDataGridViewToFile(dataGridView1, "Diem.txt");
                cbChonNhom_SelectedIndexChanged(sender, e);
            }
        }

        private void bXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
                cs.LoadToDataGridView(dataGridView1, "Diem.txt");
                if (cbChonNhom.Text == dataGridView1[0, hangDuocChon].Value.ToString())
                {
                    dataGridView1.Rows.RemoveAt(hangDuocChon);
                }
                cs.WriteDataGridViewToFile(dataGridView1, "Diem.txt");
                cbChonNhom_SelectedIndexChanged(sender, e);
            }
        }
    }
}
