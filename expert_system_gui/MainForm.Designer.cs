namespace expert_system_gui
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            bt_sukien = new System.Windows.Forms.Button();
            bt_luat = new System.Windows.Forms.Button();
            bt_tuvan = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // bt_sukien
            // 
            bt_sukien.BackColor = System.Drawing.Color.White;
            bt_sukien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_sukien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            bt_sukien.ForeColor = System.Drawing.Color.Turquoise;
            bt_sukien.Location = new System.Drawing.Point(447, 329);
            bt_sukien.Name = "bt_sukien";
            bt_sukien.Size = new System.Drawing.Size(163, 80);
            bt_sukien.TabIndex = 0;
            bt_sukien.Text = "Sự kiện";
            bt_sukien.UseVisualStyleBackColor = false;
            bt_sukien.Click += bt_sukien_Click;
            // 
            // bt_luat
            // 
            bt_luat.BackColor = System.Drawing.Color.White;
            bt_luat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_luat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            bt_luat.ForeColor = System.Drawing.Color.Turquoise;
            bt_luat.Location = new System.Drawing.Point(116, 329);
            bt_luat.Name = "bt_luat";
            bt_luat.Size = new System.Drawing.Size(165, 80);
            bt_luat.TabIndex = 1;
            bt_luat.Text = "Luật";
            bt_luat.UseVisualStyleBackColor = false;
            bt_luat.Click += bt_luat_Click;
            // 
            // bt_tuvan
            // 
            bt_tuvan.BackColor = System.Drawing.Color.White;
            bt_tuvan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_tuvan.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            bt_tuvan.ForeColor = System.Drawing.Color.Turquoise;
            bt_tuvan.Location = new System.Drawing.Point(280, 60);
            bt_tuvan.Name = "bt_tuvan";
            bt_tuvan.Size = new System.Drawing.Size(167, 85);
            bt_tuvan.TabIndex = 2;
            bt_tuvan.Text = "Tư vấn ";
            bt_tuvan.UseVisualStyleBackColor = false;
            bt_tuvan.Click += bt_tuvan_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(732, 473);
            Controls.Add(bt_tuvan);
            Controls.Add(bt_luat);
            Controls.Add(bt_sukien);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Hệ chuyên gia - MainForm";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button bt_sukien;
        private System.Windows.Forms.Button bt_luat;
        private System.Windows.Forms.Button bt_tuvan;
    }
}