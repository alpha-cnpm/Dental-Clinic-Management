namespace QLDL
{
    partial class HoaDonfrm
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
            this.mpkbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mabnbox = new System.Windows.Forms.TextBox();
            this.trieuchungbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ngaykhamdate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.thanhtientxt = new System.Windows.Forms.TextBox();
            this.xacnhanbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu Khám";
            // 
            // mpkbox
            // 
            this.mpkbox.Location = new System.Drawing.Point(160, 32);
            this.mpkbox.Name = "mpkbox";
            this.mpkbox.Size = new System.Drawing.Size(288, 26);
            this.mpkbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Bệnh Nhân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(521, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Khám";
            // 
            // mabnbox
            // 
            this.mabnbox.Location = new System.Drawing.Point(160, 87);
            this.mabnbox.Name = "mabnbox";
            this.mabnbox.Size = new System.Drawing.Size(288, 26);
            this.mabnbox.TabIndex = 5;
            // 
            // trieuchungbox
            // 
            this.trieuchungbox.Location = new System.Drawing.Point(678, 32);
            this.trieuchungbox.Name = "trieuchungbox";
            this.trieuchungbox.Size = new System.Drawing.Size(288, 26);
            this.trieuchungbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(521, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Triệu Chứng";
            // 
            // ngaykhamdate
            // 
            this.ngaykhamdate.Location = new System.Drawing.Point(678, 88);
            this.ngaykhamdate.Name = "ngaykhamdate";
            this.ngaykhamdate.Size = new System.Drawing.Size(288, 26);
            this.ngaykhamdate.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ngaykhamdate);
            this.panel1.Controls.Add(this.mpkbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.mabnbox);
            this.panel1.Controls.Add(this.trieuchungbox);
            this.panel1.Location = new System.Drawing.Point(12, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 148);
            this.panel1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(423, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 37);
            this.label7.TabIndex = 14;
            this.label7.Text = "HÓA ĐƠN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datagridview);
            this.panel2.Location = new System.Drawing.Point(13, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 300);
            this.panel2.TabIndex = 15;
            // 
            // datagridview
            // 
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Location = new System.Drawing.Point(0, 3);
            this.datagridview.Name = "datagridview";
            this.datagridview.RowTemplate.Height = 28;
            this.datagridview.Size = new System.Drawing.Size(997, 297);
            this.datagridview.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(426, 605);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thành Tiền";
            // 
            // thanhtientxt
            // 
            this.thanhtientxt.Location = new System.Drawing.Point(537, 599);
            this.thanhtientxt.Name = "thanhtientxt";
            this.thanhtientxt.Size = new System.Drawing.Size(441, 26);
            this.thanhtientxt.TabIndex = 13;
            // 
            // xacnhanbtn
            // 
            this.xacnhanbtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.xacnhanbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xacnhanbtn.Location = new System.Drawing.Point(814, 650);
            this.xacnhanbtn.Name = "xacnhanbtn";
            this.xacnhanbtn.Size = new System.Drawing.Size(129, 35);
            this.xacnhanbtn.TabIndex = 16;
            this.xacnhanbtn.Text = "Xác Nhận";
            this.xacnhanbtn.UseVisualStyleBackColor = false;
            // 
            // HoaDonfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1025, 713);
            this.Controls.Add(this.xacnhanbtn);
            this.Controls.Add(this.thanhtientxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "HoaDonfrm";
            this.Text = "HoaDonfrm";
            this.Load += new System.EventHandler(this.HoaDonfrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mpkbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mabnbox;
        private System.Windows.Forms.TextBox trieuchungbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ngaykhamdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox thanhtientxt;
        private System.Windows.Forms.Button xacnhanbtn;
    }
}