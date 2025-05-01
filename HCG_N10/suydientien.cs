// File: suydientien.cs (đã nâng cấp với xử lý xung đột luật)
using System;
using System.Collections.Generic;
using System.Data;

namespace HCG_N10
{
    class suydientien
    {
        #region Khai báo biến
        private ketnoi csdl = new ketnoi(); // Đối tượng kết nối CSDL
        List<luat_suy_dien> danh_sach_luat = new List<luat_suy_dien>(); // Tập luật gốc
        List<luat_suy_dien> luat_co_the_ap_dung = new List<luat_suy_dien>(); // Danh sách luật có thể áp dụng tại thời điểm hiện tại
        public List<string> buoc_suy_dien = new List<string>(); // Ghi lại quá trình suy diễn từng bước
        private int tong_so_luat = 0;
        #endregion

        /// <summary>
        /// Đọc luật từ bảng TapLuat (NoiDung, DoUuTien)
        /// Luật ưu tiên cao sẽ được xét trước khi có xung đột
        /// </summary>
        public void doc_luat_tu_csdl()
        {
            danh_sach_luat.Clear();
            string cau_truy_van = "SELECT NoiDung, DoUuTien FROM TapLuat ORDER BY DoUuTien DESC";
            DataTable bang_luat = csdl.getTable(cau_truy_van);

            foreach (DataRow row in bang_luat.Rows)
            {
                string noi_dung_luat = row[0].ToString();
                int do_uu_tien = Convert.ToInt32(row["DoUuTien"]);
            

                luat_suy_dien luat = new luat_suy_dien();
                luat.do_uu_tien = do_uu_tien; // Gán độ ưu tiên cho luật

                string[] ve_trai_va_phai = noi_dung_luat.Split('>');
                string[] cac_su_kien_trai = ve_trai_va_phai[0].Split('^');
                string[] cac_su_kien_phai = ve_trai_va_phai[1].Split(',');

                foreach (string sk in cac_su_kien_trai)
                    luat.ve_trai.Add(sk.Trim());

                foreach (string sk in cac_su_kien_phai)
                    luat.ve_phai.Add(sk.Trim());

                danh_sach_luat.Add(luat);
                tong_so_luat++;
            }
        }

        // Kiểm tra tất cả phần tử a có nằm trong b hay không
        public bool kiem_tra_bao_ham(List<string> danh_sach_a, List<string> danh_sach_b)
        {
            foreach (string su_kien in danh_sach_a)
                if (!danh_sach_b.Contains(su_kien)) return false;
            return true;
        }

        // Tìm các luật có thể áp dụng dựa vào tập sự kiện hiện tại
        public void tim_cac_luat_co_the_ap_dung(List<string> danh_sach_su_kien, List<luat_suy_dien> tap_luat_con_lai)
        {
            foreach (luat_suy_dien luat in tap_luat_con_lai)
            {
                if (kiem_tra_bao_ham(luat.ve_trai, danh_sach_su_kien) && !luat_co_the_ap_dung.Contains(luat))
                {
                    luat_co_the_ap_dung.Add(luat);
                }
            }

            // Sắp xếp lại theo độ ưu tiên cao nhất (giải quyết xung đột)
            luat_co_the_ap_dung.Sort((a, b) => b.do_uu_tien.CompareTo(a.do_uu_tien));
        }

        /// <summary>
        /// Suy diễn tiến: từ giả thiết tìm đến kết luận
        /// </summary>
        public bool suy_dien_tien(List<string> gia_thiet, List<string> ket_luan)
        {
            buoc_suy_dien.Clear();
            List<luat_suy_dien> tap_luat = new List<luat_suy_dien>(danh_sach_luat); // Sao chép để xử lý
            List<string> tap_su_kien = new List<string>(gia_thiet);

            tim_cac_luat_co_the_ap_dung(tap_su_kien, tap_luat);

            while (luat_co_the_ap_dung.Count > 0 && !kiem_tra_bao_ham(ket_luan, tap_su_kien))
            {
                luat_suy_dien luat_dang_ap_dung = luat_co_the_ap_dung[0]; // Lấy luật ưu tiên cao nhất

                luat_co_the_ap_dung.RemoveAt(0);
                tap_luat.Remove(luat_dang_ap_dung);

                foreach (string su_kien in luat_dang_ap_dung.ve_phai)
                {
                    if (!tap_su_kien.Contains(su_kien))
                    {
                        tap_su_kien.Add(su_kien);
                        buoc_suy_dien.Add($"✔ Suy ra: {su_kien} từ luật ({string.Join(" ^ ", luat_dang_ap_dung.ve_trai)} > {string.Join(", ", luat_dang_ap_dung.ve_phai)}) [Ưu tiên: {luat_dang_ap_dung.do_uu_tien}]");
                    }
                }

                tim_cac_luat_co_the_ap_dung(tap_su_kien, tap_luat); // Tìm tiếp luật mới
            }

            return kiem_tra_bao_ham(ket_luan, tap_su_kien);
        }
    }
}
