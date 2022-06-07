
namespace QLKS
{
    partial class frmTaoTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.cbxVaiTro = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnChonMaNV = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = " Chọn nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = " Chọn vai trò:";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(202, 197);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.ReadOnly = true;
            this.txtLoginName.Size = new System.Drawing.Size(254, 28);
            this.txtLoginName.TabIndex = 3;
            // 
            // cbxVaiTro
            // 
            this.cbxVaiTro.FormattingEnabled = true;
            this.cbxVaiTro.Location = new System.Drawing.Point(202, 258);
            this.cbxVaiTro.Name = "cbxVaiTro";
            this.cbxVaiTro.Size = new System.Drawing.Size(254, 28);
            this.cbxVaiTro.TabIndex = 4;
            this.cbxVaiTro.SelectedIndexChanged += new System.EventHandler(this.cbxVaiTro_SelectedIndexChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(202, 128);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(254, 28);
            this.txtMaNV.TabIndex = 5;
            // 
            // btnChonMaNV
            // 
            this.btnChonMaNV.Location = new System.Drawing.Point(480, 122);
            this.btnChonMaNV.Name = "btnChonMaNV";
            this.btnChonMaNV.Size = new System.Drawing.Size(151, 32);
            this.btnChonMaNV.TabIndex = 6;
            this.btnChonMaNV.Text = " Chọn mã NV";
            this.btnChonMaNV.UseVisualStyleBackColor = true;
            this.btnChonMaNV.Click += new System.EventHandler(this.btnChonMaNV_Click);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(135, 359);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(134, 41);
            this.btnTao.TabIndex = 7;
            this.btnTao.Text = " Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(375, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 41);
            this.button3.TabIndex = 8;
            this.button3.Text = " Hủy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tạo tài khoản";
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 459);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.btnChonMaNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.cbxVaiTro);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "frmTaoTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.ComboBox cbxVaiTro;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnChonMaNV;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
    }
}