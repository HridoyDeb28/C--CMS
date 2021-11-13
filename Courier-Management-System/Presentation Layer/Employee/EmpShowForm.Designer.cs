namespace Final_Project.Presentation_Layer.Employee
{
    partial class EmpShowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpShowForm));
            this.panelEmployeeShow = new System.Windows.Forms.Panel();
            this.DataGridViewShow = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.panelEmployeeShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShow)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmployeeShow
            // 
            this.panelEmployeeShow.BackColor = System.Drawing.SystemColors.Menu;
            this.panelEmployeeShow.Controls.Add(this.DataGridViewShow);
            this.panelEmployeeShow.Controls.Add(this.label12);
            this.panelEmployeeShow.Location = new System.Drawing.Point(13, 81);
            this.panelEmployeeShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelEmployeeShow.Name = "panelEmployeeShow";
            this.panelEmployeeShow.Size = new System.Drawing.Size(721, 544);
            this.panelEmployeeShow.TabIndex = 51;
            // 
            // DataGridViewShow
            // 
            this.DataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewShow.Location = new System.Drawing.Point(4, 55);
            this.DataGridViewShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridViewShow.Name = "DataGridViewShow";
            this.DataGridViewShow.RowHeadersWidth = 62;
            this.DataGridViewShow.Size = new System.Drawing.Size(694, 481);
            this.DataGridViewShow.TabIndex = 6;
            this.DataGridViewShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewShow_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Purple;
            this.label12.Location = new System.Drawing.Point(298, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "Show From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.MenuText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(228, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 37);
            this.label6.TabIndex = 52;
            this.label6.Text = "Employee Form";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(690, 27);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(44, 39);
            this.lblClose.TabIndex = 95;
            this.lblClose.Text = "   ";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // EmpShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(753, 638);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelEmployeeShow);
            this.Name = "EmpShowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpShowForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmpShowForm_FormClosing);
            this.Load += new System.EventHandler(this.EmpShowForm_Load);
            this.panelEmployeeShow.ResumeLayout(false);
            this.panelEmployeeShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEmployeeShow;
        private System.Windows.Forms.DataGridView DataGridViewShow;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblClose;
    }
}