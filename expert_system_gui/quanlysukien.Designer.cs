
namespace expert_system_gui
{
    partial class quanlysukien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlysukien));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txt_masukien = new System.Windows.Forms.TextBox();
            txt_mota = new System.Windows.Forms.TextBox();
            bt_them = new System.Windows.Forms.Button();
            bt_sua = new System.Windows.Forms.Button();
            bt_xoa = new System.Windows.Forms.Button();
            bt_tim = new System.Windows.Forms.Button();
            dataSukien = new System.Windows.Forms.DataGridView();
            masukien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            loaisukien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label3 = new System.Windows.Forms.Label();
            txt_loaisk = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataSukien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.Turquoise;
            label1.Location = new System.Drawing.Point(111, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã sự kiện";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.Turquoise;
            label2.Location = new System.Drawing.Point(151, 156);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 23);
            label2.TabIndex = 1;
            label2.Text = "Mô tả";
            label2.Click += label2_Click;
            // 
            // txt_masukien
            // 
            txt_masukien.BackColor = System.Drawing.Color.White;
            txt_masukien.Location = new System.Drawing.Point(214, 39);
            txt_masukien.Name = "txt_masukien";
            txt_masukien.Size = new System.Drawing.Size(262, 27);
            txt_masukien.TabIndex = 2;
            // 
            // txt_mota
            // 
            txt_mota.BackColor = System.Drawing.Color.White;
            txt_mota.Location = new System.Drawing.Point(214, 156);
            txt_mota.Multiline = true;
            txt_mota.Name = "txt_mota";
            txt_mota.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txt_mota.Size = new System.Drawing.Size(262, 100);
            txt_mota.TabIndex = 3;
            // 
            // bt_them
            // 
            bt_them.BackColor = System.Drawing.Color.White;
            bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_them.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            bt_them.ForeColor = System.Drawing.Color.DarkTurquoise;
            bt_them.Location = new System.Drawing.Point(517, 96);
            bt_them.Name = "bt_them";
            bt_them.Size = new System.Drawing.Size(97, 40);
            bt_them.TabIndex = 4;
            bt_them.Text = "Thêm";
            bt_them.UseVisualStyleBackColor = false;
            bt_them.Click += bt_them_Click;
            // 
            // bt_sua
            // 
            bt_sua.BackColor = System.Drawing.Color.White;
            bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_sua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            bt_sua.ForeColor = System.Drawing.Color.DarkTurquoise;
            bt_sua.Location = new System.Drawing.Point(517, 156);
            bt_sua.Name = "bt_sua";
            bt_sua.Size = new System.Drawing.Size(97, 40);
            bt_sua.TabIndex = 5;
            bt_sua.Text = "Sửa";
            bt_sua.UseVisualStyleBackColor = false;
            bt_sua.Click += bt_sua_Click;
            // 
            // bt_xoa
            // 
            bt_xoa.BackColor = System.Drawing.Color.White;
            bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_xoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            bt_xoa.ForeColor = System.Drawing.Color.DarkTurquoise;
            bt_xoa.Location = new System.Drawing.Point(517, 216);
            bt_xoa.Name = "bt_xoa";
            bt_xoa.Size = new System.Drawing.Size(97, 40);
            bt_xoa.TabIndex = 6;
            bt_xoa.Text = "Xóa";
            bt_xoa.UseVisualStyleBackColor = false;
            bt_xoa.Click += bt_xoa_Click;
            // 
            // bt_tim
            // 
            bt_tim.BackColor = System.Drawing.Color.White;
            bt_tim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_tim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            bt_tim.ForeColor = System.Drawing.Color.DarkTurquoise;
            bt_tim.Location = new System.Drawing.Point(517, 39);
            bt_tim.Name = "bt_tim";
            bt_tim.Size = new System.Drawing.Size(97, 40);
            bt_tim.TabIndex = 7;
            bt_tim.Text = "Tìm kiếm";
            bt_tim.UseVisualStyleBackColor = false;
            bt_tim.Click += bt_tim_Click;
            // 
            // dataSukien
            // 
            dataSukien.BackgroundColor = System.Drawing.Color.White;
            dataSukien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataSukien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSukien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { masukien, mota, loaisukien });
            dataSukien.Location = new System.Drawing.Point(111, 274);
            dataSukien.Name = "dataSukien";
            dataSukien.RowHeadersWidth = 51;
            dataSukien.Size = new System.Drawing.Size(503, 183);
            dataSukien.TabIndex = 8;
            dataSukien.CellClick += dataCellclick;
            // 
            // masukien
            // 
            masukien.DataPropertyName = "masukien";
            masukien.HeaderText = "Mã sự kiện";
            masukien.MinimumWidth = 6;
            masukien.Name = "masukien";
            masukien.Width = 125;
            // 
            // mota
            // 
            mota.DataPropertyName = "mota";
            mota.HeaderText = "Mô tả";
            mota.MinimumWidth = 6;
            mota.Name = "mota";
            mota.Width = 200;
            // 
            // loaisukien
            // 
            loaisukien.DataPropertyName = "loaisukien";
            loaisukien.HeaderText = "Loại sự kiện";
            loaisukien.MinimumWidth = 6;
            loaisukien.Name = "loaisukien";
            loaisukien.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.Turquoise;
            label3.Location = new System.Drawing.Point(103, 97);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 23);
            label3.TabIndex = 9;
            label3.Text = "Loại sự kiện";
            label3.Click += label3_Click;
            // 
            // txt_loaisk
            // 
            txt_loaisk.BackColor = System.Drawing.Color.White;
            txt_loaisk.Location = new System.Drawing.Point(214, 96);
            txt_loaisk.Name = "txt_loaisk";
            txt_loaisk.Size = new System.Drawing.Size(262, 27);
            txt_loaisk.TabIndex = 10;
            // 
            // quanlysukien
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(732, 455);
            Controls.Add(txt_loaisk);
            Controls.Add(label3);
            Controls.Add(dataSukien);
            Controls.Add(bt_tim);
            Controls.Add(bt_xoa);
            Controls.Add(bt_sua);
            Controls.Add(bt_them);
            Controls.Add(txt_mota);
            Controls.Add(txt_masukien);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = System.Drawing.Color.Turquoise;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "quanlysukien";
            Text = "Quản lý sự kiện";
            Load += quanlysukien_Load;
            ((System.ComponentModel.ISupportInitialize)dataSukien).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_masukien;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.DataGridView dataSukien;
        private System.Windows.Forms.DataGridViewTextBoxColumn masukien;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisukien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_loaisk;
    }
}