namespace IN451_Unit3_Justin_Meyer.UI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.Button btnLoadCustomers;
        private System.Windows.Forms.Button btnLoadCustomerLast;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label lblCustomersCount;
        private System.Windows.Forms.Button btnLoadEmployees;
        private System.Windows.Forms.Button btnLoadEmployeeLast;
        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.Label lblEmployeesCount;
        private System.Windows.Forms.Button btnLoadOrders;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Label lblOrdersCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.lblCustomersCount = new System.Windows.Forms.Label();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.btnLoadCustomerLast = new System.Windows.Forms.Button();
            this.btnLoadCustomers = new System.Windows.Forms.Button();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.lblEmployeesCount = new System.Windows.Forms.Label();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.btnLoadEmployeeLast = new System.Windows.Forms.Button();
            this.btnLoadEmployees = new System.Windows.Forms.Button();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.lblOrdersCount = new System.Windows.Forms.Label();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.btnLoadOrders = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            this.tabOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabCustomers);
            this.tabControl1.Controls.Add(this.tabEmployees);
            this.tabControl1.Controls.Add(this.tabOrders);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.lblCustomersCount);
            this.tabCustomers.Controls.Add(this.lstCustomers);
            this.tabCustomers.Controls.Add(this.btnLoadCustomerLast);
            this.tabCustomers.Controls.Add(this.btnLoadCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(532, 321);
            this.tabCustomers.TabIndex = 0;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // lblCustomersCount
            // 
            this.lblCustomersCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCustomersCount.AutoSize = true;
            this.lblCustomersCount.Location = new System.Drawing.Point(8, 295);
            this.lblCustomersCount.Name = "lblCustomersCount";
            this.lblCustomersCount.Size = new System.Drawing.Size(82, 13);
            this.lblCustomersCount.TabIndex = 3;
            this.lblCustomersCount.Text = "Customers: N/A";
            // 
            // lstCustomers
            // 
            this.lstCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.IntegralHeight = false;
            this.lstCustomers.Location = new System.Drawing.Point(8, 48);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(516, 244);
            this.lstCustomers.TabIndex = 2;
            // 
            // btnLoadCustomerLast
            // 
            this.btnLoadCustomerLast.Location = new System.Drawing.Point(134, 12);
            this.btnLoadCustomerLast.Name = "btnLoadCustomerLast";
            this.btnLoadCustomerLast.Size = new System.Drawing.Size(150, 30);
            this.btnLoadCustomerLast.TabIndex = 1;
            this.btnLoadCustomerLast.Text = "Load Last Names";
            this.btnLoadCustomerLast.UseVisualStyleBackColor = true;
            this.btnLoadCustomerLast.Click += new System.EventHandler(this.btnLoadCustomerLast_Click);
            // 
            // btnLoadCustomers
            // 
            this.btnLoadCustomers.Location = new System.Drawing.Point(8, 12);
            this.btnLoadCustomers.Name = "btnLoadCustomers";
            this.btnLoadCustomers.Size = new System.Drawing.Size(120, 30);
            this.btnLoadCustomers.TabIndex = 0;
            this.btnLoadCustomers.Text = "Load Names";
            this.btnLoadCustomers.UseVisualStyleBackColor = true;
            this.btnLoadCustomers.Click += new System.EventHandler(this.btnLoadCustomers_Click);
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.lblEmployeesCount);
            this.tabEmployees.Controls.Add(this.lstEmployees);
            this.tabEmployees.Controls.Add(this.btnLoadEmployeeLast);
            this.tabEmployees.Controls.Add(this.btnLoadEmployees);
            this.tabEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployees.Size = new System.Drawing.Size(532, 321);
            this.tabEmployees.TabIndex = 1;
            this.tabEmployees.Text = "Employees";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // lblEmployeesCount
            // 
            this.lblEmployeesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmployeesCount.AutoSize = true;
            this.lblEmployeesCount.Location = new System.Drawing.Point(8, 295);
            this.lblEmployeesCount.Name = "lblEmployeesCount";
            this.lblEmployeesCount.Size = new System.Drawing.Size(85, 13);
            this.lblEmployeesCount.TabIndex = 7;
            this.lblEmployeesCount.Text = "Employees: N/A";
            // 
            // lstEmployees
            // 
            this.lstEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.IntegralHeight = false;
            this.lstEmployees.Location = new System.Drawing.Point(8, 48);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(516, 244);
            this.lstEmployees.TabIndex = 6;
            // 
            // btnLoadEmployeeLast
            // 
            this.btnLoadEmployeeLast.Location = new System.Drawing.Point(134, 12);
            this.btnLoadEmployeeLast.Name = "btnLoadEmployeeLast";
            this.btnLoadEmployeeLast.Size = new System.Drawing.Size(150, 30);
            this.btnLoadEmployeeLast.TabIndex = 5;
            this.btnLoadEmployeeLast.Text = "Load Last Names";
            this.btnLoadEmployeeLast.UseVisualStyleBackColor = true;
            this.btnLoadEmployeeLast.Click += new System.EventHandler(this.btnLoadEmployeeLast_Click);
            // 
            // btnLoadEmployees
            // 
            this.btnLoadEmployees.Location = new System.Drawing.Point(8, 12);
            this.btnLoadEmployees.Name = "btnLoadEmployees";
            this.btnLoadEmployees.Size = new System.Drawing.Size(120, 30);
            this.btnLoadEmployees.TabIndex = 4;
            this.btnLoadEmployees.Text = "Load Names";
            this.btnLoadEmployees.UseVisualStyleBackColor = true;
            this.btnLoadEmployees.Click += new System.EventHandler(this.btnLoadEmployees_Click);
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.lblOrdersCount);
            this.tabOrders.Controls.Add(this.lstOrders);
            this.tabOrders.Controls.Add(this.btnLoadOrders);
            this.tabOrders.Location = new System.Drawing.Point(4, 22);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(532, 321);
            this.tabOrders.TabIndex = 2;
            this.tabOrders.Text = "Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // lblOrdersCount
            // 
            this.lblOrdersCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOrdersCount.AutoSize = true;
            this.lblOrdersCount.Location = new System.Drawing.Point(8, 295);
            this.lblOrdersCount.Name = "lblOrdersCount";
            this.lblOrdersCount.Size = new System.Drawing.Size(66, 13);
            this.lblOrdersCount.TabIndex = 10;
            this.lblOrdersCount.Text = "Orders: N/A";
            // 
            // lstOrders
            // 
            this.lstOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.IntegralHeight = false;
            this.lstOrders.Location = new System.Drawing.Point(8, 48);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(516, 244);
            this.lstOrders.TabIndex = 9;
            // 
            // btnLoadOrders
            // 
            this.btnLoadOrders.Location = new System.Drawing.Point(8, 12);
            this.btnLoadOrders.Name = "btnLoadOrders";
            this.btnLoadOrders.Size = new System.Drawing.Size(120, 30);
            this.btnLoadOrders.TabIndex = 8;
            this.btnLoadOrders.Text = "Load Orders";
            this.btnLoadOrders.UseVisualStyleBackColor = true;
            this.btnLoadOrders.Click += new System.EventHandler(this.btnLoadOrders_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 371);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(580, 410);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwind Demo (Customers, Employees, Orders)";
            this.tabControl1.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            this.tabCustomers.PerformLayout();
            this.tabEmployees.ResumeLayout(false);
            this.tabEmployees.PerformLayout();
            this.tabOrders.ResumeLayout(false);
            this.tabOrders.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
