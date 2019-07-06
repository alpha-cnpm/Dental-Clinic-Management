namespace QLDL
{
    partial class TiepNhanfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiepNhanfrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hotentxt = new System.Windows.Forms.TextBox();
            this.ngaysinhdate = new System.Windows.Forms.DateTimePicker();
            this.nambtn = new System.Windows.Forms.RadioButton();
            this.nubtn = new System.Windows.Forms.RadioButton();
            this.diachitxt = new System.Windows.Forms.TextBox();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.thembtn = new System.Windows.Forms.Button();
            this.xoabtn = new System.Windows.Forms.Button();
            this.suabtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.mabntxt = new System.Windows.Forms.TextBox();
            this.ngaytiepnhandate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(510, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIẾP NHẬN BỆNH NHÂN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(40, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(40, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(564, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(564, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Tiếp Nhận";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(564, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ";
            // 
            // hotentxt
            // 
            this.hotentxt.Location = new System.Drawing.Point(201, 194);
            this.hotentxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hotentxt.Name = "hotentxt";
            this.hotentxt.Size = new System.Drawing.Size(313, 26);
            this.hotentxt.TabIndex = 6;
            // 
            // ngaysinhdate
            // 
            this.ngaysinhdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaysinhdate.Location = new System.Drawing.Point(704, 139);
            this.ngaysinhdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngaysinhdate.Name = "ngaysinhdate";
            this.ngaysinhdate.Size = new System.Drawing.Size(313, 26);
            this.ngaysinhdate.TabIndex = 8;
            // 
            // nambtn
            // 
            this.nambtn.AutoSize = true;
            this.nambtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nambtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nambtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nambtn.Location = new System.Drawing.Point(201, 249);
            this.nambtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nambtn.Name = "nambtn";
            this.nambtn.Size = new System.Drawing.Size(70, 24);
            this.nambtn.TabIndex = 9;
            this.nambtn.TabStop = true;
            this.nambtn.Text = "Nam";
            this.nambtn.UseVisualStyleBackColor = false;
            // 
            // nubtn
            // 
            this.nubtn.AutoSize = true;
            this.nubtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nubtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nubtn.Location = new System.Drawing.Point(340, 249);
            this.nubtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nubtn.Name = "nubtn";
            this.nubtn.Size = new System.Drawing.Size(56, 24);
            this.nubtn.TabIndex = 10;
            this.nubtn.TabStop = true;
            this.nubtn.Text = "Nữ";
            this.nubtn.UseVisualStyleBackColor = false;
            // 
            // diachitxt
            // 
            this.diachitxt.Location = new System.Drawing.Point(704, 249);
            this.diachitxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diachitxt.Name = "diachitxt";
            this.diachitxt.Size = new System.Drawing.Size(313, 26);
            this.diachitxt.TabIndex = 11;
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(16, 398);
            this.datagrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowTemplate.Height = 28;
            this.datagrid.Size = new System.Drawing.Size(1049, 375);
            this.datagrid.TabIndex = 12;
            this.datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellClick);
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // thembtn
            // 
            this.thembtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.thembtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thembtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.thembtn.Location = new System.Drawing.Point(539, 331);
            this.thembtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thembtn.Name = "thembtn";
            this.thembtn.Size = new System.Drawing.Size(128, 35);
            this.thembtn.TabIndex = 14;
            this.thembtn.Text = "Thêm ";
            this.thembtn.UseVisualStyleBackColor = false;
            this.thembtn.Click += new System.EventHandler(this.thembtn_Click);
            // 
            // xoabtn
            // 
            this.xoabtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.xoabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoabtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.xoabtn.Location = new System.Drawing.Point(704, 331);
            this.xoabtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xoabtn.Name = "xoabtn";
            this.xoabtn.Size = new System.Drawing.Size(128, 35);
            this.xoabtn.TabIndex = 15;
            this.xoabtn.Text = "Xóa";
            this.xoabtn.UseVisualStyleBackColor = false;
            this.xoabtn.Click += new System.EventHandler(this.xoabtn_Click);
            // 
            // suabtn
            // 
            this.suabtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.suabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suabtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.suabtn.Location = new System.Drawing.Point(867, 331);
            this.suabtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suabtn.Name = "suabtn";
            this.suabtn.Size = new System.Drawing.Size(128, 35);
            this.suabtn.TabIndex = 16;
            this.suabtn.Text = "Sửa";
            this.suabtn.UseVisualStyleBackColor = false;
            this.suabtn.Click += new System.EventHandler(this.suabtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(40, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mã Bệnh Nhân";
            // 
            // mabntxt
            // 
            this.mabntxt.Location = new System.Drawing.Point(201, 145);
            this.mabntxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mabntxt.Name = "mabntxt";
            this.mabntxt.Size = new System.Drawing.Size(313, 26);
            this.mabntxt.TabIndex = 18;
            this.mabntxt.TextChanged += new System.EventHandler(this.mabntxt_TextChanged);
            // 
            // ngaytiepnhandate
            // 
            this.ngaytiepnhandate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaytiepnhandate.Location = new System.Drawing.Point(704, 194);
            this.ngaytiepnhandate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngaytiepnhandate.Name = "ngaytiepnhandate";
            this.ngaytiepnhandate.Size = new System.Drawing.Size(313, 26);
            this.ngaytiepnhandate.TabIndex = 19;
            this.ngaytiepnhandate.ValueChanged += new System.EventHandler(this.ngaytiepnhandate_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // TiepNhanfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1077, 772);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ngaytiepnhandate);
            this.Controls.Add(this.mabntxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.suabtn);
            this.Controls.Add(this.xoabtn);
            this.Controls.Add(this.thembtn);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.diachitxt);
            this.Controls.Add(this.nubtn);
            this.Controls.Add(this.nambtn);
            this.Controls.Add(this.ngaysinhdate);
            this.Controls.Add(this.hotentxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TiepNhanfrm";
            this.Text = "TiepNhanfrm";
            this.Load += new System.EventHandler(this.TiepNhanfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hotentxt;
        private System.Windows.Forms.DateTimePicker ngaysinhdate;
        private System.Windows.Forms.RadioButton nambtn;
        private System.Windows.Forms.RadioButton nubtn;
        private System.Windows.Forms.TextBox diachitxt;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Button thembtn;
        private System.Windows.Forms.Button xoabtn;
        private System.Windows.Forms.Button suabtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mabntxt;
        private System.Windows.Forms.DateTimePicker ngaytiepnhandate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}