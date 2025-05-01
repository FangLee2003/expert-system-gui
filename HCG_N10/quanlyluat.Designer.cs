
namespace HCG_N10
{
    partial class quanlyluat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlyluat));
            txt_timkiem = new System.Windows.Forms.TextBox();
            txt_maluat = new System.Windows.Forms.TextBox();
            txt_noidung = new System.Windows.Forms.TextBox();
            txt_douutien = new System.Windows.Forms.TextBox();
            bt_tim = new System.Windows.Forms.Button();
            bt_them = new System.Windows.Forms.Button();
            bt_sua = new System.Windows.Forms.Button();
            bt_xoa = new System.Windows.Forms.Button();
            dataLuat = new System.Windows.Forms.DataGridView();
            maluat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            douutien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataLuat).BeginInit();
            SuspendLayout();
            // 
            // txt_timkiem
            // 
            txt_timkiem.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            txt_timkiem.Location = new System.Drawing.Point(140, 48);
            txt_timkiem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new System.Drawing.Size(419, 30);
            txt_timkiem.TabIndex = 3;
            // 
            // txt_maluat
            // 
            txt_maluat.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            txt_maluat.Location = new System.Drawing.Point(140, 102);
            txt_maluat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            txt_maluat.Name = "txt_maluat";
            txt_maluat.Size = new System.Drawing.Size(204, 30);
            txt_maluat.TabIndex = 4;
            // 
            // txt_noidung
            // 
            txt_noidung.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            txt_noidung.Location = new System.Drawing.Point(140, 151);
            txt_noidung.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            txt_noidung.Multiline = true;
            txt_noidung.Name = "txt_noidung";
            txt_noidung.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txt_noidung.Size = new System.Drawing.Size(500, 65);
            txt_noidung.TabIndex = 5;
            // 
            // txt_douutien
            // 
            txt_douutien.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            txt_douutien.Location = new System.Drawing.Point(488, 100);
            txt_douutien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            txt_douutien.Name = "txt_douutien";
            txt_douutien.Size = new System.Drawing.Size(152, 30);
            txt_douutien.TabIndex = 6;
            // 
            // bt_tim
            // 
            bt_tim.BackgroundImage = (System.Drawing.Image)resources.GetObject("bt_tim.BackgroundImage");
            bt_tim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_tim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            bt_tim.Location = new System.Drawing.Point(658, 40);
            bt_tim.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            bt_tim.Name = "bt_tim";
            bt_tim.Size = new System.Drawing.Size(96, 36);
            bt_tim.TabIndex = 6;
            bt_tim.Text = "Tìm kiếm";
            bt_tim.UseVisualStyleBackColor = true;
            bt_tim.Click += bt_tim_Click;
            // 
            // bt_them
            // 
            bt_them.BackgroundImage = (System.Drawing.Image)resources.GetObject("bt_them.BackgroundImage");
            bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_them.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            bt_them.Location = new System.Drawing.Point(658, 94);
            bt_them.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            bt_them.Name = "bt_them";
            bt_them.Size = new System.Drawing.Size(94, 36);
            bt_them.TabIndex = 7;
            bt_them.Text = "Thêm";
            bt_them.UseVisualStyleBackColor = true;
            bt_them.Click += bt_them_Click;
            // 
            // bt_sua
            // 
            bt_sua.BackgroundImage = (System.Drawing.Image)resources.GetObject("bt_sua.BackgroundImage");
            bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_sua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            bt_sua.Location = new System.Drawing.Point(658, 151);
            bt_sua.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            bt_sua.Name = "bt_sua";
            bt_sua.Size = new System.Drawing.Size(94, 36);
            bt_sua.TabIndex = 8;
            bt_sua.Text = "Sửa ";
            bt_sua.UseVisualStyleBackColor = true;
            bt_sua.Click += bt_sua_Click;
            // 
            // bt_xoa
            // 
            bt_xoa.BackgroundImage = (System.Drawing.Image)resources.GetObject("bt_xoa.BackgroundImage");
            bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_xoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            bt_xoa.Location = new System.Drawing.Point(658, 204);
            bt_xoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            bt_xoa.Name = "bt_xoa";
            bt_xoa.Size = new System.Drawing.Size(94, 36);
            bt_xoa.TabIndex = 9;
            bt_xoa.Text = "Xóa";
            bt_xoa.UseVisualStyleBackColor = true;
            bt_xoa.Click += bt_xoa_Click;
            // 
            // dataLuat
            // 
            dataLuat.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 192);
            dataLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { maluat, noidung, douutien });
            dataLuat.Location = new System.Drawing.Point(140, 245);
            dataLuat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataLuat.Name = "dataLuat";
            dataLuat.RowHeadersWidth = 51;
            dataLuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataLuat.ShowRowErrors = false;
            dataLuat.Size = new System.Drawing.Size(573, 230);
            dataLuat.TabIndex = 0;
            dataLuat.CellClick += dataCellclick;
            dataLuat.CellContentClick += dataLuat_CellContentClick;
            // 
            // maluat
            // 
            maluat.DataPropertyName = "maluat";
            maluat.HeaderText = "Mã Luật";
            maluat.MinimumWidth = 6;
            maluat.Name = "maluat";
            maluat.Width = 150;
            // 
            // noidung
            // 
            noidung.DataPropertyName = "noidung";
            noidung.HeaderText = "Nội Dung";
            noidung.MinimumWidth = 6;
            noidung.Name = "noidung";
            noidung.Width = 220;
            // 
            // douutien
            // 
            douutien.DataPropertyName = "DoUuTien";
            douutien.HeaderText = "Độ Ưu Tiên";
            douutien.MinimumWidth = 6;
            douutien.Name = "douutien";
            douutien.Width = 150;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(30, 153);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(100, 28);
            label4.TabIndex = 12;
            label4.Text = "Nội dung";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label5.Location = new System.Drawing.Point(45, 102);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(85, 28);
            label5.TabIndex = 11;
            label5.Text = "Mã luật";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label6.Location = new System.Drawing.Point(30, 48);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(100, 28);
            label6.TabIndex = 10;
            label6.Text = "Tìm kiếm";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label7.Location = new System.Drawing.Point(368, 102);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(113, 28);
            label7.TabIndex = 13;
            label7.Text = "Độ ưu tiên";
            // 
            // quanlyluat
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(828, 446);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(dataLuat);
            Controls.Add(bt_xoa);
            Controls.Add(bt_sua);
            Controls.Add(bt_them);
            Controls.Add(bt_tim);
            Controls.Add(txt_noidung);
            Controls.Add(txt_maluat);
            Controls.Add(txt_timkiem);
            Controls.Add(txt_douutien);
            Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            Name = "quanlyluat";
            Text = "Quản lý luật";
            Load += quanlyluat_Load;
            ((System.ComponentModel.ISupportInitialize)dataLuat).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.TextBox txt_maluat;
        private System.Windows.Forms.TextBox txt_noidung;
        private System.Windows.Forms.TextBox txt_douutien;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.DataGridView dataLuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maluat;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn douutien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}