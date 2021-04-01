
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
            this.panel_top_login = new System.Windows.Forms.Panel();
            this.label_Login = new System.Windows.Forms.Label();
            this.tk = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Summit = new System.Windows.Forms.Button();
            this.button_Register = new System.Windows.Forms.Button();
            this.panel_top_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top_login
            // 
            this.panel_top_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.panel_top_login.Controls.Add(this.label_Login);
            this.panel_top_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top_login.Location = new System.Drawing.Point(0, 0);
            this.panel_top_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_top_login.Name = "panel_top_login";
            this.panel_top_login.Size = new System.Drawing.Size(518, 120);
            this.panel_top_login.TabIndex = 0;
            // 
            // label_Login
            // 
            this.label_Login.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.label_Login.Location = new System.Drawing.Point(38, 10);
            this.label_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(438, 90);
            this.label_Login.TabIndex = 0;
            this.label_Login.Text = "LOGIN";
            this.label_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tk
            // 
            this.tk.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tk.Location = new System.Drawing.Point(38, 176);
            this.tk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(438, 77);
            this.tk.TabIndex = 1;
            this.tk.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(38, 296);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(438, 77);
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // button_Summit
            // 
            this.button_Summit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.button_Summit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Summit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(177)))), ((int)(((byte)(176)))));
            this.button_Summit.Location = new System.Drawing.Point(38, 418);
            this.button_Summit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Summit.Name = "button_Summit";
            this.button_Summit.Size = new System.Drawing.Size(438, 62);
            this.button_Summit.TabIndex = 3;
            this.button_Summit.Text = "Summit";
            this.button_Summit.UseVisualStyleBackColor = false;
            this.button_Summit.Click += new System.EventHandler(this.button_Summit_Click);
            // 
            // button_Register
            // 
            this.button_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(193)))), ((int)(((byte)(243)))));
            this.button_Register.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.button_Register.Location = new System.Drawing.Point(38, 520);
            this.button_Register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(438, 62);
            this.button_Register.TabIndex = 4;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 652);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.button_Summit);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.tk);
            this.Controls.Add(this.panel_top_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.panel_top_login.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top_login;
        private System.Windows.Forms.TextBox tk;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Summit;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Label label_Login;
    }
}

