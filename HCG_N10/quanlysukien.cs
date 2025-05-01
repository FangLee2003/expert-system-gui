using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HCG_N10
{
    public partial class quanlysukien : System.Windows.Forms.Form
    {
        sukienxl xl = new sukienxl();
        public quanlysukien()
        {
            InitializeComponent();
        }

        private void quanlysukien_Load(object sender, EventArgs e)
        {
            dataSukien.DataSource = xl.loadsukien();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            sukien sk = new sukien();
            sk.MaSuKien = txt_masukien.Text;
            sk.MoTa = txt_mota.Text;
            sk.LoaiSuKien = txt_loaisk.Text;
            if (xl.timkiem(sk.MaSuKien).Rows.Count == 0)
            {
                xl.them(sk);
            }
            else
            {
                MessageBox.Show("Mã sự kiện này đã tồn tại !");
            }
            dataSukien.DataSource = xl.loadsukien();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            sukien sk = new sukien();
            sk.MaSuKien = txt_masukien.Text;
            sk.MoTa = txt_mota.Text;
            sk.LoaiSuKien = txt_loaisk.Text;
            xl.sua(sk);
            dataSukien.DataSource = xl.loadsukien();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            String mask;
            mask = txt_masukien.Text;
            xl.xoa(mask);
            dataSukien.DataSource = xl.loadsukien();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            String mask;
            mask = txt_masukien.Text;

            dataSukien.DataSource = xl.timkiem(mask);
        }

        private void dataCellclick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            if (id >= 0 && id < dataSukien.Rows.Count)
            {
                this.txt_masukien.Text = dataSukien.Rows[id].Cells[0].Value.ToString();
                this.txt_mota.Text = dataSukien.Rows[id].Cells[1].Value.ToString();
                this.txt_loaisk.Text = dataSukien.Rows[id].Cells[2].Value.ToString();

            }
        }

        private void dataSukien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
