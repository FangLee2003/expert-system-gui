// Tích hợp logic suy diễn tiến + lùi vào tuvan.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace expert_system_gui
{
    public partial class tuvan : Form
    {
        private List<string> ds_ma_sach = new List<string>();     // Danh sách mã sách từ CSDL
        private List<string> ds_ten_sach = new List<string>();    // Danh sách mô tả sách
        private ketnoi csdl = new ketnoi();                       // Đối tượng kết nối cơ sở dữ liệu
        private bool dang_chay = false;                           // Trạng thái tiến trình tư vấn

        private suydientien may_suy_dien_tien = new suydientien();   // Máy suy diễn tiến
        private suydienlui may_suy_dien_lui = new suydienlui();      // Máy suy diễn lùi

        public tuvan()
        {
            InitializeComponent();
        }

        private void tuvan_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn &&
                    btn != bt_tuvan &&
                    btn != bt_chonlai &&
                    btn.Name != "bt_tuvan" &&
                    btn.Name != "bt_chonlai")
                {
                    this.Controls.Remove(btn); // Xoá khỏi giao diện
                    btn.Dispose();             // Giải phóng bộ nhớ
                }
            }

            // Load danh sách sách (loại = 'Sach') từ CSDL
            string cau_lenh = "select MaSuKien, MoTa from SuKien where LoaiSuKien='Sach'";
            DataTable bang_sach = csdl.getTable(cau_lenh);
            for (int i = 0; i < bang_sach.Rows.Count; i++)
            {
                ds_ma_sach.Add(bang_sach.Rows[i][0].ToString());
                ds_ten_sach.Add(bang_sach.Rows[i][1].ToString());
            }

            // Load các thuộc tính (DoTuoi, TacGia, TheLoai,...) vào ComboBox
            loadComboBox("DoTuoi", cb_dotuoi);
            loadComboBox("NhaXuatBan", cb_nxb);
            loadComboBox("TheLoai", cb_theloai);
            loadComboBox("TacGia", cb_tacgia);
            loadComboBox("GiaTien", cb_giatien);
            loadComboBox("NgheNghiep", cb_job);
        }

        // Hàm hỗ trợ load các giá trị ComboBox theo loại sự kiện
        private void loadComboBox(string loai_su_kien, ComboBox comboBox)
        {
            string qr = $"select MaSuKien, MoTa from SuKien where LoaiSuKien = '{loai_su_kien}'";
            DataTable tb = csdl.getTable(qr);
            comboBox.DataSource = tb;
            comboBox.DisplayMember = "MoTa";
            comboBox.ValueMember = "MaSuKien";
        }

        private void bt_tuvan_Click(object sender, EventArgs e)
        {
            // ===== RESET =====
            treeSuyDien.Nodes.Clear();
            richKQ.Clear();
            dang_chay = true;

            // Lấy giả thiết từ người dùng chọn
            List<string> gia_thiet = new List<string>();
            if (!string.IsNullOrEmpty(cb_nxb.Text)) gia_thiet.Add(cb_nxb.SelectedValue.ToString());
            if (!string.IsNullOrEmpty(cb_theloai.Text)) gia_thiet.Add(cb_theloai.SelectedValue.ToString());
            if (!string.IsNullOrEmpty(cb_tacgia.Text)) gia_thiet.Add(cb_tacgia.SelectedValue.ToString());
            if (!string.IsNullOrEmpty(cb_giatien.Text)) gia_thiet.Add(cb_giatien.SelectedValue.ToString());
            if (!string.IsNullOrEmpty(cb_job.Text)) gia_thiet.Add(cb_job.SelectedValue.ToString());
            if (!string.IsNullOrEmpty(cb_dotuoi.Text)) gia_thiet.Add(cb_dotuoi.SelectedValue.ToString());

            if (gia_thiet.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một tiêu chí để tư vấn.");
                return;
            }

            progressBar.Minimum = 0;
            progressBar.Maximum = ds_ma_sach.Count - 1;

            // ===== Chọn chế độ suy diễn =====
            bool la_suy_dien_tien = rbTien.Checked;

            int dem_sach = 0;

            if (la_suy_dien_tien)
            {
                may_suy_dien_tien.doc_luat_tu_csdl();
            }
            else
            {
                may_suy_dien_lui.doc_luat_tu_csdl();
            }

            for (int i = 0; i < ds_ma_sach.Count; i++)
            {
                progressBar.Value = i;
                string ma_sach = ds_ma_sach[i];
                string ten_sach = ds_ten_sach[i];

                bool ket_qua = false;

                if (la_suy_dien_tien)
                {
                    ket_qua = may_suy_dien_tien.suy_dien_tien(gia_thiet, new List<string> { ma_sach });
                }
                else
                {
                    ket_qua = may_suy_dien_lui.suy_dien_lui(gia_thiet, ma_sach);
                }

                if (ket_qua)
                {
                    dem_sach++;
                    richKQ.AppendText("- " + ten_sach + "\n");

                    // Hiển thị cây
                    TreeNode sachNode = new TreeNode(ten_sach);
                    List<string> buoc_suy_dien = la_suy_dien_tien ? may_suy_dien_tien.buoc_suy_dien : may_suy_dien_lui.buoc_suy_dien;

                    foreach (string buoc in buoc_suy_dien)
                    {
                        sachNode.Nodes.Add(new TreeNode(buoc));
                    }
                    treeSuyDien.Nodes.Add(sachNode);
                }
            }

            if (dem_sach == 0)
            {
                richKQ.Text = "Không có sách nào phù hợp với yêu cầu của bạn.";
            }
        }

        private void bt_chonlai_Click(object sender, EventArgs e)
        {
            cb_nxb.Text = "";
            cb_theloai.Text = "";
            cb_tacgia.Text = "";
            cb_giatien.Text = "";
            cb_job.Text = "";
            cb_dotuoi.Text = "";
            richKQ.Clear();
            treeSuyDien.Nodes.Clear();
            progressBar.Value = 0;
        }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void richKQ_TextChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
