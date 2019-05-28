namespace CarWinForm
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
            this.dgvClientList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabView = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvCatalog = new System.Windows.Forms.DataGridView();
            this.brnRefreshCatalog = new System.Windows.Forms.Button();
            this.btnAddOp = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvInventoryList = new System.Windows.Forms.DataGridView();
            this.btnRefreshInventory = new System.Windows.Forms.Button();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvStaffList = new System.Windows.Forms.DataGridView();
            this.btnRefreshStaff = new System.Windows.Forms.Button();
            this.btnAddMecanic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).BeginInit();
            this.tabView.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryList)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientList
            // 
            this.dgvClientList.AllowUserToAddRows = false;
            this.dgvClientList.AllowUserToDeleteRows = false;
            this.dgvClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientList.Location = new System.Drawing.Point(3, 15);
            this.dgvClientList.Name = "dgvClientList";
            this.dgvClientList.ReadOnly = true;
            this.dgvClientList.Size = new System.Drawing.Size(879, 334);
            this.dgvClientList.TabIndex = 0;
            this.dgvClientList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientList_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 364);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(211, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.tabPage1);
            this.tabView.Controls.Add(this.tabPage2);
            this.tabView.Controls.Add(this.tabPage3);
            this.tabView.Controls.Add(this.tabPage4);
            this.tabView.Location = new System.Drawing.Point(12, 12);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(896, 426);
            this.tabView.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvClientList);
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(888, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clients";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvCatalog);
            this.tabPage2.Controls.Add(this.brnRefreshCatalog);
            this.tabPage2.Controls.Add(this.btnAddOp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(888, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Catalog";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCatalog
            // 
            this.dgvCatalog.AllowUserToAddRows = false;
            this.dgvCatalog.AllowUserToDeleteRows = false;
            this.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalog.Location = new System.Drawing.Point(5, 14);
            this.dgvCatalog.Name = "dgvCatalog";
            this.dgvCatalog.ReadOnly = true;
            this.dgvCatalog.Size = new System.Drawing.Size(879, 334);
            this.dgvCatalog.TabIndex = 3;
            this.dgvCatalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalog_CellContentClick);
            // 
            // brnRefreshCatalog
            // 
            this.brnRefreshCatalog.Location = new System.Drawing.Point(8, 363);
            this.brnRefreshCatalog.Name = "brnRefreshCatalog";
            this.brnRefreshCatalog.Size = new System.Drawing.Size(211, 23);
            this.brnRefreshCatalog.TabIndex = 5;
            this.brnRefreshCatalog.Text = "Refresh List";
            this.brnRefreshCatalog.UseVisualStyleBackColor = true;
            this.brnRefreshCatalog.Click += new System.EventHandler(this.brnRefreshCatalog_Click);
            // 
            // btnAddOp
            // 
            this.btnAddOp.Location = new System.Drawing.Point(689, 363);
            this.btnAddOp.Name = "btnAddOp";
            this.btnAddOp.Size = new System.Drawing.Size(195, 23);
            this.btnAddOp.TabIndex = 4;
            this.btnAddOp.Text = "Add Operation";
            this.btnAddOp.UseVisualStyleBackColor = true;
            this.btnAddOp.Click += new System.EventHandler(this.btnAddOp_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvInventoryList);
            this.tabPage3.Controls.Add(this.btnRefreshInventory);
            this.tabPage3.Controls.Add(this.btnAddMaterial);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(888, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inventory";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvInventoryList
            // 
            this.dgvInventoryList.AllowUserToAddRows = false;
            this.dgvInventoryList.AllowUserToDeleteRows = false;
            this.dgvInventoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryList.Location = new System.Drawing.Point(5, 14);
            this.dgvInventoryList.Name = "dgvInventoryList";
            this.dgvInventoryList.ReadOnly = true;
            this.dgvInventoryList.Size = new System.Drawing.Size(879, 334);
            this.dgvInventoryList.TabIndex = 3;
            this.dgvInventoryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryList_CellContentClick);
            // 
            // btnRefreshInventory
            // 
            this.btnRefreshInventory.Location = new System.Drawing.Point(8, 363);
            this.btnRefreshInventory.Name = "btnRefreshInventory";
            this.btnRefreshInventory.Size = new System.Drawing.Size(211, 23);
            this.btnRefreshInventory.TabIndex = 5;
            this.btnRefreshInventory.Text = "Refresh List";
            this.btnRefreshInventory.UseVisualStyleBackColor = true;
            this.btnRefreshInventory.Click += new System.EventHandler(this.btnRefreshInventory_Click);
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Location = new System.Drawing.Point(689, 363);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(195, 23);
            this.btnAddMaterial.TabIndex = 4;
            this.btnAddMaterial.Text = "Add Material";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvStaffList);
            this.tabPage4.Controls.Add(this.btnRefreshStaff);
            this.tabPage4.Controls.Add(this.btnAddMecanic);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(888, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Staff";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvStaffList
            // 
            this.dgvStaffList.AllowUserToAddRows = false;
            this.dgvStaffList.AllowUserToDeleteRows = false;
            this.dgvStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffList.Location = new System.Drawing.Point(5, 14);
            this.dgvStaffList.Name = "dgvStaffList";
            this.dgvStaffList.ReadOnly = true;
            this.dgvStaffList.Size = new System.Drawing.Size(879, 334);
            this.dgvStaffList.TabIndex = 3;
            this.dgvStaffList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffList_CellContentClick);
            // 
            // btnRefreshStaff
            // 
            this.btnRefreshStaff.Location = new System.Drawing.Point(8, 363);
            this.btnRefreshStaff.Name = "btnRefreshStaff";
            this.btnRefreshStaff.Size = new System.Drawing.Size(211, 23);
            this.btnRefreshStaff.TabIndex = 5;
            this.btnRefreshStaff.Text = "Refresh List";
            this.btnRefreshStaff.UseVisualStyleBackColor = true;
            this.btnRefreshStaff.Click += new System.EventHandler(this.btnRefreshStaff_Click);
            // 
            // btnAddMecanic
            // 
            this.btnAddMecanic.Location = new System.Drawing.Point(689, 363);
            this.btnAddMecanic.Name = "btnAddMecanic";
            this.btnAddMecanic.Size = new System.Drawing.Size(195, 23);
            this.btnAddMecanic.TabIndex = 4;
            this.btnAddMecanic.Text = "Add Mecanic";
            this.btnAddMecanic.UseVisualStyleBackColor = true;
            this.btnAddMecanic.Click += new System.EventHandler(this.btnAddMecanic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.tabView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).EndInit();
            this.tabView.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryList)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabControl tabView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvCatalog;
        private System.Windows.Forms.Button brnRefreshCatalog;
        private System.Windows.Forms.Button btnAddOp;
        private System.Windows.Forms.DataGridView dgvInventoryList;
        private System.Windows.Forms.Button btnRefreshInventory;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvStaffList;
        private System.Windows.Forms.Button btnRefreshStaff;
        private System.Windows.Forms.Button btnAddMecanic;
    }
}

