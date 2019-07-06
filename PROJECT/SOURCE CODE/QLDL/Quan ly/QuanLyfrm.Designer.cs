namespace QLDL
{
    partial class QuanLyfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyfrm));
            this.khambenhbtn = new System.Windows.Forms.Button();
            this.thuocbtn = new System.Windows.Forms.Button();
            this.baocaobtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // khambenhbtn
            // 
            this.khambenhbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.khambenhbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khambenhbtn.ForeColor = System.Drawing.Color.White;
            this.khambenhbtn.Location = new System.Drawing.Point(33, 60);
            this.khambenhbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.khambenhbtn.Name = "khambenhbtn";
            this.khambenhbtn.Size = new System.Drawing.Size(166, 120);
            this.khambenhbtn.TabIndex = 0;
            this.khambenhbtn.Text = "Quản Lý Khám Bệnh";
            this.khambenhbtn.UseVisualStyleBackColor = false;
            this.khambenhbtn.Click += new System.EventHandler(this.khambenhbtn_Click);
            // 
            // thuocbtn
            // 
            this.thuocbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.thuocbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thuocbtn.ForeColor = System.Drawing.Color.White;
            this.thuocbtn.Location = new System.Drawing.Point(33, 379);
            this.thuocbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thuocbtn.Name = "thuocbtn";
            this.thuocbtn.Size = new System.Drawing.Size(166, 120);
            this.thuocbtn.TabIndex = 1;
            this.thuocbtn.Text = "Quản Lý Thuốc";
            this.thuocbtn.UseVisualStyleBackColor = false;
            this.thuocbtn.Click += new System.EventHandler(this.thuocbtn_Click);
            // 
            // baocaobtn
            // 
            this.baocaobtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.baocaobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baocaobtn.ForeColor = System.Drawing.Color.White;
            this.baocaobtn.Location = new System.Drawing.Point(33, 230);
            this.baocaobtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.baocaobtn.Name = "baocaobtn";
            this.baocaobtn.Size = new System.Drawing.Size(166, 120);
            this.baocaobtn.TabIndex = 2;
            this.baocaobtn.Text = "Báo Cáo Doanh Thu";
            this.baocaobtn.UseVisualStyleBackColor = false;
            this.baocaobtn.Click += new System.EventHandler(this.baocaobtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(33, 524);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 120);
            this.button1.TabIndex = 5;
            this.button1.Text = "Báo Cáo Sử Dụng Thuốc";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(739, 584);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // QuanLyfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 655);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.baocaobtn);
            this.Controls.Add(this.thuocbtn);
            this.Controls.Add(this.khambenhbtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyfrm";
            this.Text = "QuanLyfrm";
            this.Load += new System.EventHandler(this.QuanLyfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button khambenhbtn;
        private System.Windows.Forms.Button thuocbtn;
        private System.Windows.Forms.Button baocaobtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}