namespace Final_Project.Presentation_Layer.Employee
{
    partial class NewOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrderForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbBrach1 = new System.Windows.Forms.ComboBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.txtDesProduct = new System.Windows.Forms.TextBox();
            this.cmbSelectCategory = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblSelectItem = new System.Windows.Forms.Label();
            this.lblDestinationCustomer = new System.Windows.Forms.Label();
            this.lblNewOrderFrom = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.cmbBrach1);
            this.panel1.Controls.Add(this.cmbBranch);
            this.panel1.Controls.Add(this.cmbSize);
            this.panel1.Controls.Add(this.cmbPaymentMethod);
            this.panel1.Controls.Add(this.btnSubmitOrder);
            this.panel1.Controls.Add(this.txtDesProduct);
            this.panel1.Controls.Add(this.cmbSelectCategory);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtContactNumber);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.lblSelectItem);
            this.panel1.Controls.Add(this.lblDestinationCustomer);
            this.panel1.Controls.Add(this.lblNewOrderFrom);
            this.panel1.Location = new System.Drawing.Point(49, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 588);
            this.panel1.TabIndex = 61;
            // 
            // cmbBrach1
            // 
            this.cmbBrach1.BackColor = System.Drawing.Color.Linen;
            this.cmbBrach1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrach1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbBrach1.FormattingEnabled = true;
            this.cmbBrach1.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cmbBrach1.Location = new System.Drawing.Point(100, 522);
            this.cmbBrach1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBrach1.Name = "cmbBrach1";
            this.cmbBrach1.Size = new System.Drawing.Size(312, 37);
            this.cmbBrach1.TabIndex = 37;
            this.cmbBrach1.Text = "Branch";
            // 
            // cmbBranch
            // 
            this.cmbBranch.BackColor = System.Drawing.Color.Linen;
            this.cmbBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBranch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(423, 202);
            this.cmbBranch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(230, 37);
            this.cmbBranch.TabIndex = 36;
            this.cmbBranch.Text = "Branch";
            // 
            // cmbSize
            // 
            this.cmbSize.BackColor = System.Drawing.Color.Linen;
            this.cmbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSize.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "Extra_Large"});
            this.cmbSize.Location = new System.Drawing.Point(100, 202);
            this.cmbSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(312, 37);
            this.cmbSize.TabIndex = 35;
            this.cmbSize.Text = "Size";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.BackColor = System.Drawing.Color.Linen;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(423, 152);
            this.cmbPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(230, 37);
            this.cmbPaymentMethod.TabIndex = 32;
            this.cmbPaymentMethod.Text = "Payment Method";
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmitOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitOrder.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSubmitOrder.Location = new System.Drawing.Point(462, 522);
            this.btnSubmitOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(194, 43);
            this.btnSubmitOrder.TabIndex = 31;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // txtDesProduct
            // 
            this.txtDesProduct.BackColor = System.Drawing.Color.Linen;
            this.txtDesProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesProduct.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDesProduct.Location = new System.Drawing.Point(423, 100);
            this.txtDesProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDesProduct.Name = "txtDesProduct";
            this.txtDesProduct.Size = new System.Drawing.Size(230, 35);
            this.txtDesProduct.TabIndex = 29;
            this.txtDesProduct.Text = "Describe the Product";
            this.txtDesProduct.Enter += new System.EventHandler(this.txtDesProduct_Enter);
            this.txtDesProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesProduct_KeyPress);
            this.txtDesProduct.Layout += new System.Windows.Forms.LayoutEventHandler(this.txtDesProduct_Layout);
            this.txtDesProduct.Leave += new System.EventHandler(this.txtDesProduct_Leave);
            // 
            // cmbSelectCategory
            // 
            this.cmbSelectCategory.BackColor = System.Drawing.Color.Linen;
            this.cmbSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectCategory.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbSelectCategory.FormattingEnabled = true;
            this.cmbSelectCategory.Items.AddRange(new object[] {
            "Document",
            "Package",
            "Accessories",
            "Electronics",
            "Groceries",
            "Others"});
            this.cmbSelectCategory.Location = new System.Drawing.Point(100, 100);
            this.cmbSelectCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSelectCategory.Name = "cmbSelectCategory";
            this.cmbSelectCategory.Size = new System.Drawing.Size(312, 37);
            this.cmbSelectCategory.TabIndex = 28;
            this.cmbSelectCategory.Text = "Select Category";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Linen;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAddress.Location = new System.Drawing.Point(100, 472);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(312, 35);
            this.txtAddress.TabIndex = 23;
            this.txtAddress.Text = "Address";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Linen;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtQuantity.Location = new System.Drawing.Point(100, 152);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(312, 35);
            this.txtQuantity.TabIndex = 22;
            this.txtQuantity.Text = "Quantity";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Linen;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEmail.Location = new System.Drawing.Point(100, 423);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(312, 35);
            this.txtEmail.TabIndex = 20;
            this.txtEmail.Text = "Email*";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.BackColor = System.Drawing.Color.Linen;
            this.txtContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtContactNumber.Location = new System.Drawing.Point(100, 374);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(312, 35);
            this.txtContactNumber.TabIndex = 19;
            this.txtContactNumber.Text = "Contact Number";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.Linen;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFullName.Location = new System.Drawing.Point(100, 325);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(312, 35);
            this.txtFullName.TabIndex = 18;
            this.txtFullName.Text = "Full Name";
            // 
            // lblSelectItem
            // 
            this.lblSelectItem.AutoSize = true;
            this.lblSelectItem.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSelectItem.Location = new System.Drawing.Point(102, 65);
            this.lblSelectItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectItem.Name = "lblSelectItem";
            this.lblSelectItem.Size = new System.Drawing.Size(144, 29);
            this.lblSelectItem.TabIndex = 15;
            this.lblSelectItem.Text = "Select Item";
            // 
            // lblDestinationCustomer
            // 
            this.lblDestinationCustomer.AutoSize = true;
            this.lblDestinationCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblDestinationCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationCustomer.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDestinationCustomer.Location = new System.Drawing.Point(102, 289);
            this.lblDestinationCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestinationCustomer.Name = "lblDestinationCustomer";
            this.lblDestinationCustomer.Size = new System.Drawing.Size(263, 29);
            this.lblDestinationCustomer.TabIndex = 14;
            this.lblDestinationCustomer.Text = "Destination Customer";
            // 
            // lblNewOrderFrom
            // 
            this.lblNewOrderFrom.AutoSize = true;
            this.lblNewOrderFrom.BackColor = System.Drawing.Color.LightBlue;
            this.lblNewOrderFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewOrderFrom.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNewOrderFrom.Location = new System.Drawing.Point(249, 17);
            this.lblNewOrderFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewOrderFrom.Name = "lblNewOrderFrom";
            this.lblNewOrderFrom.Size = new System.Drawing.Size(170, 25);
            this.lblNewOrderFrom.TabIndex = 5;
            this.lblNewOrderFrom.Text = "New Order From";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(786, 17);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(44, 39);
            this.lblClose.TabIndex = 96;
            this.lblClose.Text = "   ";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 615);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.panel1);
            this.Name = "NewOrderForm";
            this.Text = "NewOrderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewOrderForm_FormClosing);
            this.Load += new System.EventHandler(this.NewOrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbBrach1;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.TextBox txtDesProduct;
        private System.Windows.Forms.ComboBox cmbSelectCategory;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblSelectItem;
        private System.Windows.Forms.Label lblDestinationCustomer;
        private System.Windows.Forms.Label lblNewOrderFrom;
        private System.Windows.Forms.Label lblClose;
    }
}