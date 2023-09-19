namespace onclassweek5BT
{
    partial class Form2
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
            this.lblMSSV = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.cbmKhoa = new System.Windows.Forms.ComboBox();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblDTB = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(127, 103);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(37, 13);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(229, 103);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(180, 20);
            this.txtMSSV.TabIndex = 1;
            this.txtMSSV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbmKhoa
            // 
            this.cbmKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmKhoa.FormattingEnabled = true;
            this.cbmKhoa.Items.AddRange(new object[] {
            "CNTT",
            "QTKD",
            "NNA"});
            this.cbmKhoa.Location = new System.Drawing.Point(229, 215);
            this.cbmKhoa.Name = "cbmKhoa";
            this.cbmKhoa.Size = new System.Drawing.Size(180, 21);
            this.cbmKhoa.TabIndex = 2;
            this.cbmKhoa.SelectedIndexChanged += new System.EventHandler(this.cbmKhoa_SelectedIndexChanged);
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Location = new System.Drawing.Point(127, 160);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(43, 13);
            this.lblTenSV.TabIndex = 0;
            this.lblTenSV.Text = "Ten SV";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(127, 217);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(32, 13);
            this.lblKhoa.TabIndex = 0;
            this.lblKhoa.Text = "Khoa";
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Location = new System.Drawing.Point(127, 274);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(29, 13);
            this.lblDTB.TabIndex = 0;
            this.lblDTB.Text = "DTB";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(229, 159);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(180, 20);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(229, 272);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(180, 20);
            this.txtDTB.TabIndex = 1;
            this.txtDTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(387, 354);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(128, 21);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(578, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 21);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cbmKhoa);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.lblDTB);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lblTenSV);
            this.Controls.Add(this.lblMSSV);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.ComboBox cbmKhoa;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblDTB;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnExit;
    }
}