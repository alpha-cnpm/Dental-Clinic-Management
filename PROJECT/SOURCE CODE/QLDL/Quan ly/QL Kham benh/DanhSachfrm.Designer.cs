namespace QLDL
{
    partial class DanhSachfrm
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
            this.tracuutxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timkiembtn = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(284, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH BỆNH NHÂN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(262, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tra Cứu";
            // 
            // tracuutxt
            // 
            this.tracuutxt.Location = new System.Drawing.Point(356, 171);
            this.tracuutxt.Name = "tracuutxt";
            this.tracuutxt.Size = new System.Drawing.Size(474, 26);
            this.tracuutxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cách Tìm";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã bệnh nhân",
            "Tên bệnh nhân"});
            this.comboBox1.Location = new System.Drawing.Point(106, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // timkiembtn
            // 
            this.timkiembtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.timkiembtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiembtn.ForeColor = System.Drawing.Color.White;
            this.timkiembtn.Location = new System.Drawing.Point(857, 169);
            this.timkiembtn.Name = "timkiembtn";
            this.timkiembtn.Size = new System.Drawing.Size(118, 34);
            this.timkiembtn.TabIndex = 5;
            this.timkiembtn.Text = "Tìm Kiếm";
            this.timkiembtn.UseVisualStyleBackColor = false;
            this.timkiembtn.Click += new System.EventHandler(this.timkiembtn_Click);
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(2, 266);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowTemplate.Height = 28;
            this.datagrid.Size = new System.Drawing.Size(982, 400);
            this.datagrid.TabIndex = 6;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // DanhSachfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(987, 674);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.timkiembtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tracuutxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DanhSachfrm";
            this.Text = "DanhSachfrm";
            this.Load += new System.EventHandler(this.DanhSachfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tracuutxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button timkiembtn;
        private System.Windows.Forms.DataGridView datagrid;
    }
}