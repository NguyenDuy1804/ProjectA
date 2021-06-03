
namespace DBMS_project
{
    partial class Form_Login
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
            this.button_Summit = new System.Windows.Forms.Button();
            this.tbx_Password = new System.Windows.Forms.TextBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.panel_top_login = new System.Windows.Forms.Panel();
            this.tbx_userName = new System.Windows.Forms.TextBox();
            this.lb_userName = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.rbtn_Employee = new System.Windows.Forms.RadioButton();
            this.rbtn_Manager = new System.Windows.Forms.RadioButton();
            this.panel_top_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Summit
            // 
            this.button_Summit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.button_Summit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Summit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(177)))), ((int)(((byte)(176)))));
            this.button_Summit.Location = new System.Drawing.Point(31, 420);
            this.button_Summit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Summit.Name = "button_Summit";
            this.button_Summit.Size = new System.Drawing.Size(365, 51);
            this.button_Summit.TabIndex = 3;
            this.button_Summit.Text = "Login";
            this.button_Summit.UseVisualStyleBackColor = false;
            this.button_Summit.Click += new System.EventHandler(this.button_Summit_Click);
            // 
            // tbx_Password
            // 
            this.tbx_Password.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Password.Location = new System.Drawing.Point(31, 272);
            this.tbx_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_Password.Name = "tbx_Password";
            this.tbx_Password.Size = new System.Drawing.Size(365, 47);
            this.tbx_Password.TabIndex = 2;
            this.tbx_Password.UseSystemPasswordChar = true;
            // 
            // label_Login
            // 
            this.label_Login.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.label_Login.Location = new System.Drawing.Point(31, 9);
            this.label_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(365, 75);
            this.label_Login.TabIndex = 0;
            this.label_Login.Text = "LOGIN";
            this.label_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_top_login
            // 
            this.panel_top_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.panel_top_login.Controls.Add(this.label_Login);
            this.panel_top_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top_login.Location = new System.Drawing.Point(0, 0);
            this.panel_top_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_top_login.Name = "panel_top_login";
            this.panel_top_login.Size = new System.Drawing.Size(431, 100);
            this.panel_top_login.TabIndex = 0;
            // 
            // tbx_userName
            // 
            this.tbx_userName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_userName.Location = new System.Drawing.Point(31, 171);
            this.tbx_userName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_userName.Name = "tbx_userName";
            this.tbx_userName.Size = new System.Drawing.Size(365, 47);
            this.tbx_userName.TabIndex = 1;
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lb_userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lb_userName.Location = new System.Drawing.Point(26, 142);
            this.lb_userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(101, 25);
            this.lb_userName.TabIndex = 10;
            this.lb_userName.Text = "Username";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lb_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lb_Password.Location = new System.Drawing.Point(26, 244);
            this.lb_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(96, 25);
            this.lb_Password.TabIndex = 11;
            this.lb_Password.Text = "Password";
            // 
            // rbtn_Employee
            // 
            this.rbtn_Employee.AutoSize = true;
            this.rbtn_Employee.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbtn_Employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.rbtn_Employee.Location = new System.Drawing.Point(278, 358);
            this.rbtn_Employee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_Employee.Name = "rbtn_Employee";
            this.rbtn_Employee.Size = new System.Drawing.Size(119, 29);
            this.rbtn_Employee.TabIndex = 12;
            this.rbtn_Employee.Text = "Employee";
            this.rbtn_Employee.UseVisualStyleBackColor = true;
            this.rbtn_Employee.CheckedChanged += new System.EventHandler(this.rbtn_Employee_CheckedChanged);
            // 
            // rbtn_Manager
            // 
            this.rbtn_Manager.AutoSize = true;
            this.rbtn_Manager.Checked = true;
            this.rbtn_Manager.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbtn_Manager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.rbtn_Manager.Location = new System.Drawing.Point(31, 358);
            this.rbtn_Manager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_Manager.Name = "rbtn_Manager";
            this.rbtn_Manager.Size = new System.Drawing.Size(113, 29);
            this.rbtn_Manager.TabIndex = 13;
            this.rbtn_Manager.TabStop = true;
            this.rbtn_Manager.Text = "Manager";
            this.rbtn_Manager.UseVisualStyleBackColor = true;
            this.rbtn_Manager.CheckedChanged += new System.EventHandler(this.rbtn_Manager_CheckedChanged);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(431, 544);
            this.Controls.Add(this.rbtn_Employee);
            this.Controls.Add(this.rbtn_Manager);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_userName);
            this.Controls.Add(this.button_Summit);
            this.Controls.Add(this.tbx_Password);
            this.Controls.Add(this.tbx_userName);
            this.Controls.Add(this.panel_top_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.panel_top_login.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Summit;
        private System.Windows.Forms.TextBox tbx_Password;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Panel panel_top_login;
        private System.Windows.Forms.TextBox tbx_userName;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.RadioButton rbtn_Employee;
        private System.Windows.Forms.RadioButton rbtn_Manager;
    }
}

