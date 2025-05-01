using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace expert_system_gui
{
    public partial class quanlyluat : System.Windows.Forms.Form
    {
        luatxl xl = new luatxl();

        public quanlyluat()
        {
            InitializeComponent();
        }

        private void quanlyluat_Load(object sender, EventArgs e)
        {
            dataLuat.DataSource = xl.loadluat();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            luat l = new luat();
            l.MaLuat = txt_maluat.Text;
            l.NoiDung = txt_noidung.Text;
            if (xl.timkiem(l.MaLuat).Rows.Count == 0)
            {
                xl.them(l);
            }
            else
            {
                MessageBox.Show("Mã luật này đã tồn tại !");
            }

            dataLuat.DataSource = xl.loadluat();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            luat l = new luat();
            l.MaLuat = txt_maluat.Text;
            l.NoiDung = txt_noidung.Text;
            xl.sua(l);
            dataLuat.DataSource = xl.loadluat();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            String mal;
            mal = txt_maluat.Text;
            xl.xoa(mal);
            dataLuat.DataSource = xl.loadluat();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            String mal;
            mal = txt_timkiem.Text;
            dataLuat.DataSource = xl.timkiem(mal);
        }

        private void dataCellclick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            if (id >= 0 && id < dataLuat.Rows.Count)
            {
                this.txt_maluat.Text = dataLuat.Rows[id].Cells[0].Value.ToString();
                this.txt_noidung.Text = dataLuat.Rows[id].Cells[1].Value.ToString();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataLuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
