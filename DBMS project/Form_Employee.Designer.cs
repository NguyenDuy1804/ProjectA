
namespace DBMS_project
{
    partial class Form_Employee
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
            this.pn_top_Employee = new System.Windows.Forms.Panel();
            this.pn_Data = new System.Windows.Forms.Panel();
            this.button_CreateRP = new System.Windows.Forms.Button();
            this.lb_Employee = new System.Windows.Forms.Label();
            this.Data_Employee = new System.Windows.Forms.DataGridView();
            this.pn_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Employee)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_top_Employee
            // 
            this.pn_top_Employee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_top_Employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_top_Employee.Location = new System.Drawing.Point(0, 0);
            this.pn_top_Employee.Margin = new System.Windows.Forms.Padding(2);
            this.pn_top_Employee.Name = "pn_top_Employee";
            this.pn_top_Employee.Size = new System.Drawing.Size(879, 82);
            this.pn_top_Employee.TabIndex = 0;
            // 
            // pn_Data
            // 
            this.pn_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.pn_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Data.Controls.Add(this.button_CreateRP);
            this.pn_Data.Controls.Add(this.lb_Employee);
            this.pn_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Data.Location = new System.Drawing.Point(0, 82);
            this.pn_Data.Margin = new System.Windows.Forms.Padding(2);
            this.pn_Data.Name = "pn_Data";
            this.pn_Data.Size = new System.Drawing.Size(879, 156);
            this.pn_Data.TabIndex = 1;
            // 
            // button_CreateRP
            // 
            this.button_CreateRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.button_CreateRP.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CreateRP.ForeColor = System.Drawing.Color.DarkGray;
            this.button_CreateRP.Location = new System.Drawing.Point(713, 11);
            this.button_CreateRP.Margin = new System.Windows.Forms.Padding(2);
            this.button_CreateRP.Name = "button_CreateRP";
            this.button_CreateRP.Size = new System.Drawing.Size(156, 53);
            this.button_CreateRP.TabIndex = 2;
            this.button_CreateRP.Text = "Create list";
            this.button_CreateRP.UseVisualStyleBackColor = false;
            this.button_CreateRP.Click += new System.EventHandler(this.button_CreateRP_Click);
            // 
            // lb_Employee
            // 
            this.lb_Employee.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Employee.Location = new System.Drawing.Point(8, 11);
            this.lb_Employee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Employee.Name = "lb_Employee";
            this.lb_Employee.Size = new System.Drawing.Size(155, 36);
            this.lb_Employee.TabIndex = 1;
            this.lb_Employee.Text = "Employee";
            this.lb_Employee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Data_Employee
            // 
            this.Data_Employee.AllowUserToAddRows = false;
            this.Data_Employee.AllowUserToDeleteRows = false;
            this.Data_Employee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Data_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_Employee.Location = new System.Drawing.Point(9, 190);
            this.Data_Employee.Margin = new System.Windows.Forms.Padding(2);
            this.Data_Employee.Name = "Data_Employee";
            this.Data_Employee.ReadOnly = true;
            this.Data_Employee.RowHeadersWidth = 51;
            this.Data_Employee.RowTemplate.Height = 24;
            this.Data_Employee.Size = new System.Drawing.Size(861, 405);
            this.Data_Employee.TabIndex = 0;
            // 
            // Form_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 602);
            this.Controls.Add(this.Data_Employee);
            this.Controls.Add(this.pn_Data);
            this.Controls.Add(this.pn_top_Employee);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Employee";
            this.Text = "Form_Employee";
            this.Load += new System.EventHandler(this.Form_Employee_Load);
            this.pn_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Employee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_top_Employee;
        private System.Windows.Forms.Panel pn_Data;
        private System.Windows.Forms.DataGridView Data_Employee;
        private System.Windows.Forms.Label lb_Employee;
        private System.Windows.Forms.Button button_CreateRP;
    }
}