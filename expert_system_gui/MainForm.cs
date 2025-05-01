using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expert_system_gui
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bt_sukien_Click(object sender, EventArgs e)
        {
            quanlysukien frm = new quanlysukien();
            frm.ShowDialog();
        }

        private void bt_luat_Click(object sender, EventArgs e)
        {
            quanlyluat qll = new quanlyluat();
            qll.ShowDialog();
        }

        private void bt_tuvan_Click(object sender, EventArgs e)
        {
            tuvan tv = new tuvan();
            tv.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e) { }
    }
}