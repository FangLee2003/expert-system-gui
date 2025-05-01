// File: suydienlui.cs
using System;
using System.Collections.Generic;
using System.Data;

namespace HCG_N10
{
    public class suydienlui
    {
        private ketnoi csdl = new ketnoi(); // Đối tượng kết nối cơ sở dữ liệu

        private List<luat_suy_dien> danh_sach_luat = new List<luat_suy_dien>(); // Danh sách luật suy diễn được phân tích từ CSDL

        public List<string> buoc_suy_dien = new List<string>(); // Danh sách ghi lại từng bước suy luận để hiển thị

        // Đọc toàn bộ luật từ CSDL và phân tích thành dạng cấu trúc ve_trai, ve_phai
        public void doc_luat_tu_csdl()
        {
            string cau_truy_van = "select NoiDung from TapLuat"; // Truy vấn toàn bộ nội dung luật
            DataTable bang_luat = csdl.getTable(cau_truy_van);

            foreach (DataRow row in bang_luat.Rows)
            {
                string noi_dung_luat = row[0].ToString(); // Ví dụ: A^B>C,D
                luat_suy_dien luat = new luat_suy_dien();

                string[] ve_trai_va_phai = noi_dung_luat.Split('>'); // Tách điều kiện và kết luận
                string[] cac_su_kien_trai = ve_trai_va_phai[0].Split('^'); // Danh sách điều kiện (vế trái)
                string[] cac_su_kien_phai = ve_trai_va_phai[1].Split(','); // Danh sách kết luận (vế phải)

                foreach (var sk in cac_su_kien_trai)
                    luat.ve_trai.Add(sk.Trim()); // Thêm vào vế trái sau khi loại bỏ khoảng trắng

                foreach (var sk in cac_su_kien_phai)
                    luat.ve_phai.Add(sk.Trim()); // Thêm vào vế phải

                danh_sach_luat.Add(luat); // Lưu vào danh sách luật
            }
        }

        /// <summary>
        /// Suy diễn lùi: kiểm tra từ kết luận truy về giả thiết
        /// </summary>
        public bool suy_dien_lui(List<string> gia_thiet, string muc_tieu)
        {
            buoc_suy_dien.Clear(); // Reset log suy diễn
            HashSet<string> tap_gia_thiet = new HashSet<string>(gia_thiet); // Chuyển danh sách giả thiết thành tập để tra cứu nhanh
            HashSet<string> visited = new HashSet<string>(); // Tập ghi nhớ các mục tiêu đã xét để tránh vòng lặp

            return truy_ve(muc_tieu, tap_gia_thiet, visited); // Bắt đầu suy diễn từ mục tiêu
        }

        // Đệ quy suy diễn lùi từ mục tiêu về giả thiết
        private bool truy_ve(string muc_tieu, HashSet<string> tap_gia_thiet, HashSet<string> visited)
        {
            if (tap_gia_thiet.Contains(muc_tieu)) // Nếu mục tiêu đã có trong giả thiết ban đầu
            {
                buoc_suy_dien.Add($"✔ {muc_tieu} thuộc giả thiết ban đầu");
                return true;
            }

            if (visited.Contains(muc_tieu))
                return false; // Nếu đã xét rồi thì bỏ qua để tránh vòng lặp vô hạn

            visited.Add(muc_tieu); // Đánh dấu đã xét

            foreach (luat_suy_dien luat in danh_sach_luat)
            {
                if (luat.ve_phai.Contains(muc_tieu)) // Nếu luật có vế phải chứa mục tiêu
                {
                    bool all_true = true;
                    foreach (string dk in luat.ve_trai) // Kiểm tra tất cả điều kiện vế trái
                    {
                        if (!truy_ve(dk, tap_gia_thiet, visited)) // Nếu 1 điều kiện không thỏa thì bỏ qua luật
                        {
                            all_true = false;
                            break;
                        }
                    }

                    if (all_true)
                    {
                        buoc_suy_dien.Add($"→ Suy ra {muc_tieu} từ luật: {string.Join(" ^ ", luat.ve_trai)} > {string.Join(", ", luat.ve_phai)}");
                        return true;
                    }
                }
            }

            buoc_suy_dien.Add($"✘ Không thể suy ra {muc_tieu}");
            return false; // Không tìm được luật nào phù hợp để suy ra mục tiêu
        }
    }
}
