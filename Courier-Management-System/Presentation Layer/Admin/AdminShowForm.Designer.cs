namespace Final_Project.Presentation_Layer.Admin
{
    partial class AdminShowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminShowForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridShowTable = new System.Windows.Forms.DataGridView();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblFormName = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.gridShowTable);
            this.panel1.Location = new System.Drawing.Point(4, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 541);
            this.panel1.TabIndex = 63;
            // 
            // gridShowTable
            // 
            this.gridShowTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShowTable.Location = new System.Drawing.Point(0, 39);
            this.gridShowTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridShowTable.Name = "gridShowTable";
            this.gridShowTable.RowHeadersWidth = 62;
            this.gridShowTable.Size = new System.Drawing.Size(873, 502);
            this.gridShowTable.TabIndex = 0;
            this.gridShowTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridShowTable_CellContentClick);
            // 
            // lblAppName
            // 
            this.lblAppName.BackColor = System.Drawing.Color.DimGray;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.Cyan;
            this.lblAppName.Location = new System.Drawing.Point(293, 635);
            this.lblAppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(201, 29);
            this.lblAppName.TabIndex = 82;
            this.lblAppName.Text = "Courier Service";
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.BackColor = System.Drawing.SystemColors.MenuText;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFormName.Location = new System.Drawing.Point(242, 24);
            this.lblFormName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(204, 37);
            this.lblFormName.TabIndex = 92;
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
            this.lblClose.Location = new System.Drawing.Point(790, 24);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(44, 39);
            this.lblClose.TabIndex = 94;
            this.lblClose.Text = "   ";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // AdminShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(904, 673);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.panel1);
            this.Name = "AdminShowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminShowForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminShowForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminShowForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridShowTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridShowTable;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblClose;
    }
}