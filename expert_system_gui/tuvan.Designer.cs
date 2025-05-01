
namespace expert_system_gui
{
    partial class tuvan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tuvan));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            cb_nxb = new System.Windows.Forms.ComboBox();
            cb_theloai = new System.Windows.Forms.ComboBox();
            cb_tacgia = new System.Windows.Forms.ComboBox();
            cb_giatien = new System.Windows.Forms.ComboBox();
            cb_job = new System.Windows.Forms.ComboBox();
            cb_dotuoi = new System.Windows.Forms.ComboBox();
            bt_tuvan = new System.Windows.Forms.Button();
            bt_chonlai = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            richKQ = new System.Windows.Forms.RichTextBox();
            progressBar = new System.Windows.Forms.ProgressBar();
            groupBoxMode = new System.Windows.Forms.GroupBox();
            rbTien = new System.Windows.Forms.RadioButton();
            rbLui = new System.Windows.Forms.RadioButton();
            treeSuyDien = new System.Windows.Forms.TreeView();
            groupBoxMode.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(53, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(145, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhà xuất bản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(105, 99);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Thể loại:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(115, 159);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 28);
            label3.TabIndex = 2;
            label3.Text = "Tác giả:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(441, 159);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(91, 28);
            label4.TabIndex = 3;
            label4.Text = "Giá tiền:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label6.Location = new System.Drawing.Point(393, 41);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(139, 28);
            label6.TabIndex = 5;
            label6.Text = "Nghề nghiệp:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label7.Location = new System.Drawing.Point(444, 99);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(88, 28);
            label7.TabIndex = 6;
            label7.Text = "Độ tuổi:";
            // 
            // cb_nxb
            // 
            cb_nxb.BackColor = System.Drawing.Color.White;
            cb_nxb.FormattingEnabled = true;
            cb_nxb.Location = new System.Drawing.Point(208, 45);
            cb_nxb.Name = "cb_nxb";
            cb_nxb.Size = new System.Drawing.Size(151, 28);
            cb_nxb.TabIndex = 7;
            // 
            // cb_theloai
            // 
            cb_theloai.BackColor = System.Drawing.Color.White;
            cb_theloai.FormattingEnabled = true;
            cb_theloai.Location = new System.Drawing.Point(208, 100);
            cb_theloai.Name = "cb_theloai";
            cb_theloai.Size = new System.Drawing.Size(151, 28);
            cb_theloai.TabIndex = 8;
            // 
            // cb_tacgia
            // 
            cb_tacgia.BackColor = System.Drawing.Color.White;
            cb_tacgia.FormattingEnabled = true;
            cb_tacgia.Location = new System.Drawing.Point(208, 159);
            cb_tacgia.Name = "cb_tacgia";
            cb_tacgia.Size = new System.Drawing.Size(151, 28);
            cb_tacgia.TabIndex = 9;
            // 
            // cb_giatien
            // 
            cb_giatien.BackColor = System.Drawing.Color.White;
            cb_giatien.FormattingEnabled = true;
            cb_giatien.Location = new System.Drawing.Point(541, 159);
            cb_giatien.Name = "cb_giatien";
            cb_giatien.Size = new System.Drawing.Size(151, 28);
            cb_giatien.TabIndex = 10;
            // 
            // cb_job
            // 
            cb_job.BackColor = System.Drawing.Color.White;
            cb_job.FormattingEnabled = true;
            cb_job.Location = new System.Drawing.Point(541, 41);
            cb_job.Name = "cb_job";
            cb_job.Size = new System.Drawing.Size(151, 28);
            cb_job.TabIndex = 12;
            // 
            // cb_dotuoi
            // 
            cb_dotuoi.BackColor = System.Drawing.Color.White;
            cb_dotuoi.FormattingEnabled = true;
            cb_dotuoi.Location = new System.Drawing.Point(541, 99);
            cb_dotuoi.Name = "cb_dotuoi";
            cb_dotuoi.Size = new System.Drawing.Size(151, 28);
            cb_dotuoi.TabIndex = 13;
            // 
            // bt_tuvan
            // 
            bt_tuvan.BackColor = System.Drawing.Color.White;
            bt_tuvan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_tuvan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            bt_tuvan.ForeColor = System.Drawing.Color.Turquoise;
            bt_tuvan.Location = new System.Drawing.Point(725, 143);
            bt_tuvan.Name = "bt_tuvan";
            bt_tuvan.Size = new System.Drawing.Size(96, 44);
            bt_tuvan.TabIndex = 14;
            bt_tuvan.Text = "Tư Vấn";
            bt_tuvan.UseVisualStyleBackColor = false;
            bt_tuvan.Click += bt_tuvan_Click;
            // 
            // bt_chonlai
            // 
            bt_chonlai.BackColor = System.Drawing.Color.White;
            bt_chonlai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_chonlai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            bt_chonlai.ForeColor = System.Drawing.Color.Turquoise;
            bt_chonlai.Location = new System.Drawing.Point(827, 143);
            bt_chonlai.Name = "bt_chonlai";
            bt_chonlai.Size = new System.Drawing.Size(94, 44);
            bt_chonlai.TabIndex = 15;
            bt_chonlai.Text = "Chọn lại";
            bt_chonlai.UseVisualStyleBackColor = false;
            bt_chonlai.Click += bt_chonlai_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label8.Location = new System.Drawing.Point(105, 213);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(93, 28);
            label8.TabIndex = 16;
            label8.Text = "Kết Quả:";
            // 
            // richKQ
            // 
            richKQ.BackColor = System.Drawing.Color.White;
            richKQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            richKQ.ForeColor = System.Drawing.SystemColors.ControlText;
            richKQ.Location = new System.Drawing.Point(53, 275);
            richKQ.Name = "richKQ";
            richKQ.Size = new System.Drawing.Size(409, 248);
            richKQ.TabIndex = 17;
            richKQ.Text = "";
            richKQ.TextChanged += richKQ_TextChanged;
            // 
            // progressBar
            // 
            progressBar.BackColor = System.Drawing.Color.White;
            progressBar.ForeColor = System.Drawing.Color.Turquoise;
            progressBar.Location = new System.Drawing.Point(208, 216);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(713, 28);
            progressBar.TabIndex = 18;
            // 
            // groupBoxMode
            // 
            groupBoxMode.BackColor = System.Drawing.Color.White;
            groupBoxMode.Controls.Add(rbTien);
            groupBoxMode.Controls.Add(rbLui);
            groupBoxMode.ForeColor = System.Drawing.Color.Black;
            groupBoxMode.Location = new System.Drawing.Point(725, 37);
            groupBoxMode.Name = "groupBoxMode";
            groupBoxMode.Size = new System.Drawing.Size(196, 90);
            groupBoxMode.TabIndex = 19;
            groupBoxMode.TabStop = false;
            groupBoxMode.Text = "Chế độ suy diễn";
            // 
            // rbTien
            // 
            rbTien.AutoSize = true;
            rbTien.Checked = true;
            rbTien.Location = new System.Drawing.Point(10, 25);
            rbTien.Name = "rbTien";
            rbTien.Size = new System.Drawing.Size(115, 24);
            rbTien.TabIndex = 1;
            rbTien.TabStop = true;
            rbTien.Text = "Suy diễn tiến";
            rbTien.UseVisualStyleBackColor = true;
            // 
            // rbLui
            // 
            rbLui.AutoSize = true;
            rbLui.Location = new System.Drawing.Point(10, 55);
            rbLui.Name = "rbLui";
            rbLui.Size = new System.Drawing.Size(106, 24);
            rbLui.TabIndex = 2;
            rbLui.Text = "Suy diễn lùi";
            rbLui.UseVisualStyleBackColor = true;
            // 
            // treeSuyDien
            // 
            treeSuyDien.BackColor = System.Drawing.Color.White;
            treeSuyDien.Location = new System.Drawing.Point(502, 275);
            treeSuyDien.Name = "treeSuyDien";
            treeSuyDien.Size = new System.Drawing.Size(419, 248);
            treeSuyDien.TabIndex = 20;
            // 
            // tuvan
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(989, 520);
            Controls.Add(richKQ);
            Controls.Add(progressBar);
            Controls.Add(label8);
            Controls.Add(bt_chonlai);
            Controls.Add(bt_tuvan);
            Controls.Add(cb_dotuoi);
            Controls.Add(cb_job);
            Controls.Add(cb_giatien);
            Controls.Add(cb_tacgia);
            Controls.Add(cb_theloai);
            Controls.Add(cb_nxb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBoxMode);
            Controls.Add(treeSuyDien);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "tuvan";
            Text = "Tư vấn chọn sách";
            Load += tuvan_Load;
            Controls.SetChildIndex(treeSuyDien, 0);
            Controls.SetChildIndex(groupBoxMode, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(cb_nxb, 0);
            Controls.SetChildIndex(cb_theloai, 0);
            Controls.SetChildIndex(cb_tacgia, 0);
            Controls.SetChildIndex(cb_giatien, 0);
            Controls.SetChildIndex(cb_job, 0);
            Controls.SetChildIndex(cb_dotuoi, 0);
            Controls.SetChildIndex(bt_tuvan, 0);
            Controls.SetChildIndex(bt_chonlai, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(progressBar, 0);
            Controls.SetChildIndex(richKQ, 0);
            groupBoxMode.ResumeLayout(false);
            groupBoxMode.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_nxb;
        private System.Windows.Forms.ComboBox cb_theloai;
        private System.Windows.Forms.ComboBox cb_tacgia;
        private System.Windows.Forms.ComboBox cb_giatien;
        private System.Windows.Forms.ComboBox cb_job;
        private System.Windows.Forms.ComboBox cb_dotuoi;
        private System.Windows.Forms.Button bt_tuvan;
        private System.Windows.Forms.Button bt_chonlai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richKQ;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RadioButton rbTien;
        private System.Windows.Forms.RadioButton rbLui;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.TreeView treeSuyDien;

    }
}