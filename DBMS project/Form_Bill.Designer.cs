
namespace DBMS_project
{
    partial class Form_Bill
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
            this.label_Title = new System.Windows.Forms.Label();
            this.label_CustomerName = new System.Windows.Forms.Label();
            this.textBox_CusName = new System.Windows.Forms.TextBox();
            this.label_CusID = new System.Windows.Forms.Label();
            this.textBox_CusID = new System.Windows.Forms.TextBox();
            this.label_EmpID = new System.Windows.Forms.Label();
            this.textBox_EmpID = new System.Windows.Forms.TextBox();
            this.label_EmpName = new System.Windows.Forms.Label();
            this.textBox_EmpName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.labelNumCus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label_Title.Location = new System.Drawing.Point(156, 25);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(125, 54);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Invoice";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_CustomerName
            // 
            this.label_CustomerName.AutoSize = true;
            this.label_CustomerName.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label_CustomerName.Location = new System.Drawing.Point(3, 167);
            this.label_CustomerName.Name = "label_CustomerName";
            this.label_CustomerName.Size = new System.Drawing.Size(164, 30);
            this.label_CustomerName.TabIndex = 1;
            this.label_CustomerName.Text = "Customer Name: ";
            // 
            // textBox_CusName
            // 
            this.textBox_CusName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.textBox_CusName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CusName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CusName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox_CusName.Location = new System.Drawing.Point(173, 167);
            this.textBox_CusName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_CusName.Name = "textBox_CusName";
            this.textBox_CusName.Size = new System.Drawing.Size(235, 23);
            this.textBox_CusName.TabIndex = 2;
            this.textBox_CusName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_CusID
            // 
            this.label_CusID.AutoSize = true;
            this.label_CusID.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CusID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label_CusID.Location = new System.Drawing.Point(3, 103);
            this.label_CusID.Name = "label_CusID";
            this.label_CusID.Size = new System.Drawing.Size(133, 30);
            this.label_CusID.TabIndex = 3;
            this.label_CusID.Text = "Customer ID: ";
            // 
            // textBox_CusID
            // 
            this.textBox_CusID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.textBox_CusID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CusID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CusID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox_CusID.Location = new System.Drawing.Point(173, 111);
            this.textBox_CusID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_CusID.Name = "textBox_CusID";
            this.textBox_CusID.Size = new System.Drawing.Size(235, 23);
            this.textBox_CusID.TabIndex = 4;
            this.textBox_CusID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_EmpID
            // 
            this.label_EmpID.AutoSize = true;
            this.label_EmpID.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EmpID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label_EmpID.Location = new System.Drawing.Point(3, 223);
            this.label_EmpID.Name = "label_EmpID";
            this.label_EmpID.Size = new System.Drawing.Size(134, 30);
            this.label_EmpID.TabIndex = 5;
            this.label_EmpID.Text = "Employee ID: ";
            // 
            // textBox_EmpID
            // 
            this.textBox_EmpID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.textBox_EmpID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EmpID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EmpID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox_EmpID.Location = new System.Drawing.Point(173, 226);
            this.textBox_EmpID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_EmpID.Name = "textBox_EmpID";
            this.textBox_EmpID.Size = new System.Drawing.Size(235, 23);
            this.textBox_EmpID.TabIndex = 6;
            this.textBox_EmpID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_EmpID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_EmpID_KeyDown);
            // 
            // label_EmpName
            // 
            this.label_EmpName.AutoSize = true;
            this.label_EmpName.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EmpName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label_EmpName.Location = new System.Drawing.Point(3, 279);
            this.label_EmpName.Name = "label_EmpName";
            this.label_EmpName.Size = new System.Drawing.Size(165, 30);
            this.label_EmpName.TabIndex = 7;
            this.label_EmpName.Text = "Employee Name: ";
            // 
            // textBox_EmpName
            // 
            this.textBox_EmpName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.textBox_EmpName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_EmpName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EmpName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox_EmpName.Location = new System.Drawing.Point(173, 286);
            this.textBox_EmpName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_EmpName.Name = "textBox_EmpName";
            this.textBox_EmpName.Size = new System.Drawing.Size(235, 23);
            this.textBox_EmpName.TabIndex = 8;
            this.textBox_EmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNumCus);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(475, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 741);
            this.panel1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(519, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 33);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Newest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(157, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Customer List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(0, 103);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 24;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(654, 638);
            this.dataGridViewCustomer.TabIndex = 0;
            // 
            // labelNumCus
            // 
            this.labelNumCus.AutoSize = true;
            this.labelNumCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumCus.ForeColor = System.Drawing.Color.White;
            this.labelNumCus.Location = new System.Drawing.Point(13, 50);
            this.labelNumCus.Name = "labelNumCus";
            this.labelNumCus.Size = new System.Drawing.Size(70, 29);
            this.labelNumCus.TabIndex = 12;
            this.labelNumCus.Text = "Num:";
            // 
            // Form_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1129, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_EmpName);
            this.Controls.Add(this.label_EmpName);
            this.Controls.Add(this.textBox_EmpID);
            this.Controls.Add(this.label_EmpID);
            this.Controls.Add(this.textBox_CusID);
            this.Controls.Add(this.label_CusID);
            this.Controls.Add(this.textBox_CusName);
            this.Controls.Add(this.label_CustomerName);
            this.Controls.Add(this.label_Title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Bill";
            this.Text = "Form_Bill";
            this.Load += new System.EventHandler(this.Form_Bill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_CustomerName;
        private System.Windows.Forms.TextBox textBox_CusName;
        private System.Windows.Forms.Label label_CusID;
        private System.Windows.Forms.TextBox textBox_CusID;
        private System.Windows.Forms.Label label_EmpID;
        private System.Windows.Forms.TextBox textBox_EmpID;
        private System.Windows.Forms.Label label_EmpName;
        private System.Windows.Forms.TextBox textBox_EmpName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Label labelNumCus;
    }
}