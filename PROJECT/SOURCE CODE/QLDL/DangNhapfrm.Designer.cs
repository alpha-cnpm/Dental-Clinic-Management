namespace QLDL
{
    partial class DangNhapfrm
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
            this.dangnhaptxt = new System.Windows.Forms.TextBox();
            this.matkhautxt = new System.Windows.Forms.TextBox();
            this.dangnhapbtn = new System.Windows.Forms.Button();
            this.thoatbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dangnhaptxt
            // 
            this.dangnhaptxt.Location = new System.Drawing.Point(247, 105);
            this.dangnhaptxt.Name = "dangnhaptxt";
            this.dangnhaptxt.Size = new System.Drawing.Size(266, 26);
            this.dangnhaptxt.TabIndex = 2;
            this.dangnhaptxt.TextChanged += new System.EventHandler(this.dangnhaptxt_TextChanged);
            // 
            // matkhautxt
            // 
            this.matkhautxt.Location = new System.Drawing.Point(247, 167);
            this.matkhautxt.Name = "matkhautxt";
            this.matkhautxt.Size = new System.Drawing.Size(266, 26);
            this.matkhautxt.TabIndex = 3;
            // 
            // dangnhapbtn
            // 
            this.dangnhapbtn.Location = new System.Drawing.Point(328, 269);
            this.dangnhapbtn.Name = "dangnhapbtn";
            this.dangnhapbtn.Size = new System.Drawing.Size(129, 32);
            this.dangnhapbtn.TabIndex = 4;
            this.dangnhapbtn.Text = "Đăng nhập";
            this.dangnhapbtn.UseVisualStyleBackColor = true;
            // 
            // thoatbtn
            // 
            this.thoatbtn.Location = new System.Drawing.Point(488, 269);
            this.thoatbtn.Name = "thoatbtn";
            this.thoatbtn.Size = new System.Drawing.Size(129, 32);
            this.thoatbtn.TabIndex = 5;
            this.thoatbtn.Text = "Thoát";
            this.thoatbtn.UseVisualStyleBackColor = true;
            // 
            // DangNhapfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 372);
            this.Controls.Add(this.thoatbtn);
            this.Controls.Add(this.dangnhapbtn);
            this.Controls.Add(this.matkhautxt);
            this.Controls.Add(this.dangnhaptxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangNhapfrm";
            this.Text = "DangNhapfrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dangnhaptxt;
        private System.Windows.Forms.TextBox matkhautxt;
        private System.Windows.Forms.Button dangnhapbtn;
        private System.Windows.Forms.Button thoatbtn;
    }
}