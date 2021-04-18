
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
            this.Data_Employee = new System.Windows.Forms.DataGridView();
            this.lb_Employee = new System.Windows.Forms.Label();
            this.button_CreateRP = new System.Windows.Forms.Button();
            this.pn_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Employee)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_top_Employee
            // 
            this.pn_top_Employee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_top_Employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_top_Employee.Location = new System.Drawing.Point(0, 0);
            this.pn_top_Employee.Name = "pn_top_Employee";
            this.pn_top_Employee.Size = new System.Drawing.Size(1172, 100);
            this.pn_top_Employee.TabIndex = 0;
            // 
            // pn_Data
            // 
            this.pn_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.pn_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Data.Controls.Add(this.button_CreateRP);
            this.pn_Data.Controls.Add(this.lb_Employee);
            this.pn_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Data.Location = new System.Drawing.Point(0, 100);
            this.pn_Data.Name = "pn_Data";
            this.pn_Data.Size = new System.Drawing.Size(1172, 191);
            this.pn_Data.TabIndex = 1;
            // 
            // Data_Employee
            // 
            this.Data_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Employee.Location = new System.Drawing.Point(12, 234);
            this.Data_Employee.Name = "Data_Employee";
            this.Data_Employee.RowHeadersWidth = 51;
            this.Data_Employee.RowTemplate.Height = 24;
            this.Data_Employee.Size = new System.Drawing.Size(1148, 498);
            this.Data_Employee.TabIndex = 0;
            // 
            // lb_Employee
            // 
            this.lb_Employee.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Employee.Location = new System.Drawing.Point(11, 14);
            this.lb_Employee.Name = "lb_Employee";
            this.lb_Employee.Size = new System.Drawing.Size(207, 44);
            this.lb_Employee.TabIndex = 1;
            this.lb_Employee.Text = "Employee";
            this.lb_Employee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_CreateRP
            // 
            this.button_CreateRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.button_CreateRP.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CreateRP.ForeColor = System.Drawing.Color.DarkGray;
            this.button_CreateRP.Location = new System.Drawing.Point(951, 14);
            this.button_CreateRP.Name = "button_CreateRP";
            this.button_CreateRP.Size = new System.Drawing.Size(208, 65);
            this.button_CreateRP.TabIndex = 2;
            this.button_CreateRP.Text = "Create list";
            this.button_CreateRP.UseVisualStyleBackColor = false;
            // 
            // Form_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 744);
            this.Controls.Add(this.Data_Employee);
            this.Controls.Add(this.pn_Data);
            this.Controls.Add(this.pn_top_Employee);
            this.Name = "Form_Employee";
            this.Text = "Form_Employee";
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