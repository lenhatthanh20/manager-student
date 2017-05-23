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
    public partial class frmTongKet : Form
    {
        public frmTongKet()
        {
            InitializeComponent();
        }

        csThaoTac cs = new csThaoTac();
        double[] diemTongKet = new double[9];
        public void tinhDiemTongKet(string tenFile)
        {
            StreamReader sr = new StreamReader(tenFile);
            string Line = sr.ReadLine();
            int a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0, a7 = 0, a8 = 0, a9 = 0;
            while ((Line != null) && (Line != " "))
            {
                string[] mang = Line.Split(';');
                switch (mang[0])
                { 
                    case "Nhóm 1":
                        diemTongKet[0] += double.Parse(mang[12]);
                        ++a1;
                        break;
                    case "Nhóm 2":
                        diemTongKet[1] += double.Parse(mang[12]);
                        ++a2;
                        break;
                    case "Nhóm 3":
                        diemTongKet[2] += double.Parse(mang[12]);
                        ++a3;
                        break;
                    case "Nhóm 4":
                        diemTongKet[3] += double.Parse(mang[12]);
                        ++a4;
                        break;
                    case "Nhóm 5":
                        diemTongKet[4] += double.Parse(mang[12]);
                        ++a5;
                        break;
                    case "Nhóm 6":
                        diemTongKet[5] += double.Parse(mang[12]);
                        ++a6;
                        break;
                    case "Nhóm 7":
                        diemTongKet[6] += double.Parse(mang[12]);
                        ++a7;
                        break;
                    case "Nhóm 8":
                        diemTongKet[7] += double.Parse(mang[12]);
                        ++a8;
                        break;
                    case "Nhóm 9":
                        diemTongKet[8] += double.Parse(mang[12]);
                        ++a9;
                        break;
                }
                Line = sr.ReadLine();
            }
            if (a1 != 0)
                diemTongKet[0] /= a1;
            if (a2 != 0)
                diemTongKet[1] /= a2;
            if (a3 != 0)
                diemTongKet[2] /= a3;
            if (a4 != 0)
                diemTongKet[3] /= a4;
            if (a5 != 0)
                diemTongKet[4] /= a5;
            if (a6 != 0)
                diemTongKet[5] /= a6;
            if (a7 != 0)
                diemTongKet[6] /= a7;
            if (a8 != 0)
                diemTongKet[7] /= a8;
            if (a9 != 0)
                diemTongKet[8] /= a9;

            
            sr.Close();
        }

        public void xuLyFile(DataGridView dg, string TenFile)
        {
            StreamReader sr = new StreamReader(TenFile);
            string Line = sr.ReadLine();

            tinhDiemTongKet("Diem.txt");
            while ((Line != null) && (Line != " "))
            {
                string[] mang = Line.Split(';');

                string[] mang2 = { mang[0], mang[1], mang[2], mang[5], "" };
                switch (mang2[3])
                {
                    case "Nhóm 1":
                        mang2[4] = diemTongKet[0].ToString();
                        break;
                    case "Nhóm 2":
                        mang2[4] = diemTongKet[1].ToString();
                        break;
                    case "Nhóm 3":
                        mang2[4] = diemTongKet[3].ToString();
                        break;
                    case "Nhóm 4":
                        mang2[4] = diemTongKet[4].ToString();
                        break;
                    case "Nhóm 5":
                        mang2[4] = diemTongKet[5].ToString();
                        break;
                    case "Nhóm 6":
                        mang2[4] = diemTongKet[6].ToString();
                        break;
                    case "Nhóm 7":
                        mang2[4] = diemTongKet[7].ToString();
                        break;
                    case "Nhóm 8":
                        mang2[4] = diemTongKet[8].ToString();
                        break;
                    case "Nhóm 9":
                        mang2[4] = diemTongKet[9].ToString();
                        break;
                }
                dg.Rows.Add(mang2);
                Line = sr.ReadLine();
            }
            sr.Close();
            cs.WriteDataGridViewToFile(dg, "TongKet.txt");
        }
         private void frmTongKet_Load(object sender, EventArgs e)
        {
            xuLyFile(dataGridView1, "Lop.txt");
        }
        private void cbChonNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();
            cs.LoadToDataGridView(dataGridView1, "TongKet.txt");
            for (int i = dataGridView1.RowCount - 2; i >= 0; i--)
            {
                String a = dataGridView1[3, i].Value.ToString().ToLower().Trim();
                if (cbChonNhom.Text.ToLower().Trim() != a)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
        }
        private void bTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cs.LoadToDataGridView(dataGridView1, "TongKet.txt");
            String chuoiHang = "";
            for (int hang = dataGridView1.RowCount - 2; hang >= 0; --hang)
            {
                for (int cot = 0; cot < 5; ++cot)
                {
                    String a = dataGridView1[cot, hang].Value.ToString().ToLower();
                    chuoiHang += a;                  
                }
                if (cbChonNhom.Text == "")
                {
                    if (chuoiHang.IndexOf(tTimKiem.Text.ToLower()) == -1)
                    {
                        dataGridView1.Rows.RemoveAt(hang);
                    }
                    chuoiHang = "";
                }
                else
                {
                    if (chuoiHang.IndexOf(tTimKiem.Text.ToLower()) == -1 || cbChonNhom.Text.ToLower().Trim() != dataGridView1[3, hang].Value.ToString().ToLower())
                    {
                        dataGridView1.Rows.RemoveAt(hang);
                    }
                    chuoiHang = "";
                }
            }
        }
    }
}
