namespace Final_Project.Presentation_Layer.Admin
{
    partial class AdminAddBranchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAddBranchForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblPlusIcon = new System.Windows.Forms.Label();
            this.btnAddBranch = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFormName = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.lblAppName);
            this.panel1.Controls.Add(this.lblPlusIcon);
            this.panel1.Controls.Add(this.btnAddBranch);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblMsg);
            this.panel1.Controls.Add(this.txtBranchName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 605);
            this.panel1.TabIndex = 63;
            // 
            // lblAppName
            // 
            this.lblAppName.BackColor = System.Drawing.Color.DimGray;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.Cyan;
            this.lblAppName.Location = new System.Drawing.Point(314, 549);
            this.lblAppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(199, 29);
            this.lblAppName.TabIndex = 83;
            this.lblAppName.Text = "Courier Service";
            // 
            // lblPlusIcon
            // 
            this.lblPlusIcon.AutoSize = true;
            this.lblPlusIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusIcon.Image = ((System.Drawing.Image)(resources.GetObject("lblPlusIcon.Image")));
            this.lblPlusIcon.Location = new System.Drawing.Point(273, 28);
            this.lblPlusIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlusIcon.Name = "lblPlusIcon";
            this.lblPlusIcon.Size = new System.Drawing.Size(192, 170);
            this.lblPlusIcon.TabIndex = 71;
            this.lblPlusIcon.Text = "   ";
            // 
            // btnAddBranch
            // 
            this.btnAddBranch.BackColor = System.Drawing.Color.Teal;
            this.btnAddBranch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBranch.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAddBranch.Location = new System.Drawing.Point(255, 475);
            this.btnAddBranch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddBranch.Name = "btnAddBranch";
            this.btnAddBranch.Size = new System.Drawing.Size(327, 57);
            this.btnAddBranch.TabIndex = 70;
            this.btnAddBranch.Text = "Add Branch";
            this.btnAddBranch.UseVisualStyleBackColor = false;
            this.btnAddBranch.Click += new System.EventHandler(this.btnAddBranch_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.DarkGray;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(255, 397);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(325, 41);
            this.txtAddress.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label12.Location = new System.Drawing.Point(135, 412);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 25);
            this.label12.TabIndex = 68;
            this.label12.Text = "Address";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Indigo;
            this.lblMsg.Location = new System.Drawing.Point(216, 208);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(273, 37);
            this.lblMsg.TabIndex = 67;
            this.lblMsg.Text = "Add New Branch";
            // 
            // txtBranchName
            // 
            this.txtBranchName.BackColor = System.Drawing.Color.DarkGray;
            this.txtBranchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchName.Location = new System.Drawing.Point(255, 311);
            this.txtBranchName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(325, 41);
            this.txtBranchName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(78, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch Name";
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.BackColor = System.Drawing.SystemColors.MenuText;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFormName.Location = new System.Drawing.Point(261, 9);
            this.lblFormName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(204, 37);
            this.lblFormName.TabIndex = 64;
            this.lblFormName.Text = "Admin Form";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(658, 15);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(44, 39);
            this.lblClose.TabIndex = 93;
            this.lblClose.Text = "   ";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // AdminAddBranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(731, 678);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddBranchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAddBranchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminAddBranchForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPlusIcon;
        private System.Windows.Forms.Button btnAddBranch;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblClose;
    }
}