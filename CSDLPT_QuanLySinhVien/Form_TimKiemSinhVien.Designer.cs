
namespace CSDLPT_QuanLySinhVien
{
    partial class Form_TimKiemSinhVien
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
            this.cB_Lop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_DiemTu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_DiemDen = new System.Windows.Forms.TextBox();
            this.btn_TraCuu1 = new System.Windows.Forms.Button();
            this.btn_TraCuu2 = new System.Windows.Forms.Button();
            this.dGV_TimKiem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // cB_Lop
            // 
            this.cB_Lop.FormattingEnabled = true;
            this.cB_Lop.Location = new System.Drawing.Point(130, 24);
            this.cB_Lop.Name = "cB_Lop";
            this.cB_Lop.Size = new System.Drawing.Size(202, 28);
            this.cB_Lop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm từ";
            // 
            // tB_DiemTu
            // 
            this.tB_DiemTu.Location = new System.Drawing.Point(128, 98);
            this.tB_DiemTu.Name = "tB_DiemTu";
            this.tB_DiemTu.Size = new System.Drawing.Size(202, 26);
            this.tB_DiemTu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đến";
            // 
            // tB_DiemDen
            // 
            this.tB_DiemDen.Location = new System.Drawing.Point(424, 98);
            this.tB_DiemDen.Name = "tB_DiemDen";
            this.tB_DiemDen.Size = new System.Drawing.Size(202, 26);
            this.tB_DiemDen.TabIndex = 2;
            // 
            // btn_TraCuu1
            // 
            this.btn_TraCuu1.Location = new System.Drawing.Point(380, 20);
            this.btn_TraCuu1.Name = "btn_TraCuu1";
            this.btn_TraCuu1.Size = new System.Drawing.Size(110, 34);
            this.btn_TraCuu1.TabIndex = 3;
            this.btn_TraCuu1.Text = "Tra cứu";
            this.btn_TraCuu1.UseVisualStyleBackColor = true;
            this.btn_TraCuu1.Click += new System.EventHandler(this.btn_TraCuu1_Click);
            // 
            // btn_TraCuu2
            // 
            this.btn_TraCuu2.Location = new System.Drawing.Point(656, 94);
            this.btn_TraCuu2.Name = "btn_TraCuu2";
            this.btn_TraCuu2.Size = new System.Drawing.Size(110, 34);
            this.btn_TraCuu2.TabIndex = 3;
            this.btn_TraCuu2.Text = "Tra cứu";
            this.btn_TraCuu2.UseVisualStyleBackColor = true;
            this.btn_TraCuu2.Click += new System.EventHandler(this.btn_TraCuu2_Click);
            // 
            // dGV_TimKiem
            // 
            this.dGV_TimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_TimKiem.Location = new System.Drawing.Point(23, 150);
            this.dGV_TimKiem.Name = "dGV_TimKiem";
            this.dGV_TimKiem.RowHeadersVisible = false;
            this.dGV_TimKiem.RowHeadersWidth = 62;
            this.dGV_TimKiem.RowTemplate.Height = 28;
            this.dGV_TimKiem.Size = new System.Drawing.Size(1037, 412);
            this.dGV_TimKiem.TabIndex = 4;
            // 
            // Form_TimKiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 588);
            this.Controls.Add(this.dGV_TimKiem);
            this.Controls.Add(this.btn_TraCuu2);
            this.Controls.Add(this.btn_TraCuu1);
            this.Controls.Add(this.tB_DiemDen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_DiemTu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB_Lop);
            this.Name = "Form_TimKiemSinhVien";
            this.Text = "Tìm kiếm sinh viên";
            this.Load += new System.EventHandler(this.Form_TimKiemSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_TimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cB_Lop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_DiemTu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_DiemDen;
        private System.Windows.Forms.Button btn_TraCuu1;
        private System.Windows.Forms.Button btn_TraCuu2;
        private System.Windows.Forms.DataGridView dGV_TimKiem;
    }
}