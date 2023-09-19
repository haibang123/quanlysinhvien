namespace onclassweek5BT
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tslAdd = new System.Windows.Forms.ToolStripLabel();
            this.tstbFind = new System.Windows.Forms.ToolStripTextBox();
            this.tslFind = new System.Windows.Forms.ToolStripLabel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleDescription = "c";
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chucNangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // chucNangToolStripMenuItem
            // 
            this.chucNangToolStripMenuItem.AccessibleDescription = "c";
            this.chucNangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            this.chucNangToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.chucNangToolStripMenuItem.Text = "Chuc Nang";
            this.chucNangToolStripMenuItem.Click += new System.EventHandler(this.chucNangToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.AccessibleDescription = "c";
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AccessibleDescription = "c";
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AccessibleDescription = "c";
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tslAdd,
            this.tstbFind,
            this.tslFind});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(675, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.AccessibleDescription = "c";
            this.tsbAdd.BackgroundImage = global::onclassweek5BT.Properties.Resources.z4103640094134_e29e58249181685a903eca98bec74928__1_1;
            this.tsbAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "Add";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tslAdd
            // 
            this.tslAdd.AccessibleDescription = "c";
            this.tslAdd.Name = "tslAdd";
            this.tslAdd.Size = new System.Drawing.Size(29, 22);
            this.tslAdd.Text = "Add";
            // 
            // tstbFind
            // 
            this.tstbFind.AccessibleDescription = "c";
            this.tstbFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstbFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbFind.Name = "tstbFind";
            this.tstbFind.Size = new System.Drawing.Size(400, 25);
            this.tstbFind.Enter += new System.EventHandler(this.tstbFind_Enter);
            this.tstbFind.TextChanged += new System.EventHandler(this.tstbFind_TextChanged);
            // 
            // tslFind
            // 
            this.tslFind.AccessibleDescription = "";
            this.tslFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslFind.Name = "tslFind";
            this.tslFind.Size = new System.Drawing.Size(82, 22);
            this.tslFind.Text = "Find by name:";
            this.tslFind.Click += new System.EventHandler(this.tslFind_Click);
            // 
            // dgvData
            // 
            this.dgvData.AccessibleDescription = "";
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(0, 52);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(441, 399);
            this.dgvData.TabIndex = 4;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvData);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quan Ly Sinh Vien";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chucNangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripLabel tslAdd;
        private System.Windows.Forms.ToolStripLabel tslFind;
        private System.Windows.Forms.ToolStripTextBox tstbFind;
        public System.Windows.Forms.DataGridView dgvData;
    }
}

