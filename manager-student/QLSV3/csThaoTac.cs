using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;            // thêm thư viện này để truy xuất file *.txt (notepad).
using System.Windows.Forms; // sử dụng thư viện này để truy xuất DataGridView và các thứ khác trong Windows Forms.
namespace QLSV3
{
    class csThaoTac
    {
        /// <summary>
        /// Phương thức Load dữ liệu từ Text lên DataGridView
        /// </summary>
        /// <param name="dg">Tên DataGridView</param>
        /// <param name="TenFile">Tên File</param>  
        public void LoadToDataGridView(DataGridView dg, string TenFile)
        {
            StreamReader sr = new StreamReader(TenFile); // Khai báo đối tượng StreamReader
            string Line = sr.ReadLine();                // khao báo 1 biến Line kiểu String để đọc 1 chuổi kí tự. Ở đây là đọc file TenFile được truyền vào (cụ thể là file Hocsinh.txt).
            while ((Line != null) && (Line != " "))     // trong khi line khác null (không tồn tại giá trị) và khác rỗng. thì.....
            {
                string[] mang = Line.Split(';');        // xem toàn bộ data trong notepad (file *.txt) là một chuỗi, hàm này cắt chuổi đó ra dựa vào dấu ";" và lưu tất cả lại trong 1 mảng kiểu String.
                dg.Rows.Add(mang);                      //Add mảng vào DataGridView
                Line = sr.ReadLine();
            }
            sr.Close();
        }
        /// <summary>
        /// Phương thức Lưu Dữ liệu vào Text từ DataGridView
        /// </summary>
        /// <param name="dg">Tên DataGridView</param>
        /// <param name="pathFile">Tên File</param>
        public void WriteDataGridViewToFile(DataGridView dg, string pathFile) 
        {
            StreamWriter sw = new StreamWriter(pathFile);
            string Line = "";

            for (int i = 0; i < dg.Rows.Count - 1; ++i)
            {
                if (i == dg.NewRowIndex)            //Khi chạy tới hàng mới trong bảng (hàng không có dữ liệu) thì thoát ra vòng lặp.
                {
                    break;
                }
                Line = "";                     
                for (int j = 0; j < dg.Columns.Count; ++j)
                {
                    Line += dg[j, i].Value + ";";
                }
                sw.WriteLine(Line);  //Ghi dữ liệu và xuống hàng. Ghi từng hàng một!!!!
            }
            sw.Close();
        }
        /* giải thuật là như xuất mảng 2 chiều ra màn hình vậy. Do DataGridView là một mảng 2 chiều. Nhưng ở đây mỗi khi lấy được
        * một giá trị thì ngăn cách bằng dấu ; để dùng cho việc lấy lại dữ liệu từ file text.
        * 
        * 
        * 
        * */

    }
}
