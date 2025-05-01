
namespace HCG_N10
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            bt_sukien = new System.Windows.Forms.Button();
            bt_luat = new System.Windows.Forms.Button();
            bt_tuvan = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // bt_sukien
            // 
            bt_sukien.BackgroundImage = (System.Drawing.Image)resources.GetObject("bt_sukien.BackgroundImage");
            bt_sukien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_sukien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            bt_sukien.ForeColor = System.Drawing.SystemColors.ControlText;
            bt_sukien.Location = new System.Drawing.Point(517, 284);
            bt_sukien.Name = "bt_sukien";
            bt_sukien.Size = new System.Drawing.Size(163, 80);
            bt_sukien.TabIndex = 0;
            bt_sukien.Text = "Sự kiện";
            bt_sukien.UseVisualStyleBackColor = true;
            bt_sukien.Click += bt_sukien_Click;
            // 
            // bt_luat
            // 
            bt_luat.BackgroundImage = (System.Drawing.Image)resources.GetObject("bt_luat.BackgroundImage");
            bt_luat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_luat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            bt_luat.ForeColor = System.Drawing.SystemColors.ControlText;
            bt_luat.Location = new System.Drawing.Point(320, 181);
            bt_luat.Name = "bt_luat";
            bt_luat.Size = new System.Drawing.Size(157, 80);
            bt_luat.TabIndex = 1;
            bt_luat.Text = "Luật";
            bt_luat.UseVisualStyleBackColor = true;
            bt_luat.Click += bt_luat_Click;
            // 
            // bt_tuvan
            // 
            bt_tuvan.BackgroundImage = (System.Drawing.Image)resources.GetObject("bt_tuvan.BackgroundImage");
            bt_tuvan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_tuvan.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            bt_tuvan.ForeColor = System.Drawing.SystemColors.ControlText;
            bt_tuvan.Location = new System.Drawing.Point(97, 93);
            bt_tuvan.Name = "bt_tuvan";
            bt_tuvan.Size = new System.Drawing.Size(167, 85);
            bt_tuvan.TabIndex = 2;
            bt_tuvan.Text = "Tư vấn ";
            bt_tuvan.UseVisualStyleBackColor = true;
            bt_tuvan.Click += bt_tuvan_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(766, 450);
            Controls.Add(bt_tuvan);
            Controls.Add(bt_luat);
            Controls.Add(bt_sukien);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form";
            Text = "Hệ chuyên gia tư vấn chọn sách - Nhóm 10";
            Load += Form1_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_sukien;
        private System.Windows.Forms.Button bt_luat;
        private System.Windows.Forms.Button bt_tuvan;
    }
}

