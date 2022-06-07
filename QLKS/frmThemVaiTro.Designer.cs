
namespace QLKS
{
    partial class frmThemVaiTro
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenRole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cListBoxRole = new System.Windows.Forms.CheckedListBox();
            this.bdsBoPhan = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLKS.DS();
            this.bOPHANTableAdapter = new QLKS.DSTableAdapters.BOPHANTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTaoRole = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoPhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thêm Vai Trò";
            // 
            // txtTenRole
            // 
            this.txtTenRole.Location = new System.Drawing.Point(201, 87);
            this.txtTenRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenRole.Name = "txtTenRole";
            this.txtTenRole.Size = new System.Drawing.Size(342, 23);
            this.txtTenRole.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên Vai Trò";
            // 
            // cListBoxRole
            // 
            this.cListBoxRole.FormattingEnabled = true;
            this.cListBoxRole.Location = new System.Drawing.Point(201, 136);
            this.cListBoxRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cListBoxRole.Name = "cListBoxRole";
            this.cListBoxRole.Size = new System.Drawing.Size(342, 238);
            this.cListBoxRole.TabIndex = 17;
            // 
            // bdsBoPhan
            // 
            this.bdsBoPhan.DataMember = "BOPHAN";
            this.bdsBoPhan.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOPHANTableAdapter
            // 
            this.bOPHANTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Danh sách các quyền";
            // 
            // btnTaoRole
            // 
            this.btnTaoRole.Location = new System.Drawing.Point(308, 397);
            this.btnTaoRole.Name = "btnTaoRole";
            this.btnTaoRole.Size = new System.Drawing.Size(121, 41);
            this.btnTaoRole.TabIndex = 19;
            this.btnTaoRole.Text = "Tạo vai trò";
            this.btnTaoRole.UseVisualStyleBackColor = true;
            this.btnTaoRole.Click += new System.EventHandler(this.btnTaoRole_Click);
            // 
            // frmThemVaiTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 502);
            this.Controls.Add(this.btnTaoRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cListBoxRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenRole);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmThemVaiTro";
            this.Text = "frmThemVaiTro";
            this.Load += new System.EventHandler(this.frmThemVaiTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoPhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox cListBoxRole;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsBoPhan;
        private DSTableAdapters.BOPHANTableAdapter bOPHANTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTaoRole;
    }
}