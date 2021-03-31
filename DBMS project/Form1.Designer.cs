
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
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Summit = new System.Windows.Forms.Button();
            this.button_Register = new System.Windows.Forms.Button();
            this.label_Login = new System.Windows.Forms.Label();
            this.panel_top_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top_login
            // 
            this.panel_top_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(230)))));
            this.panel_top_login.Controls.Add(this.label_Login);
            this.panel_top_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top_login.Location = new System.Drawing.Point(0, 0);
            this.panel_top_login.Name = "panel_top_login";
            this.panel_top_login.Size = new System.Drawing.Size(431, 100);
            this.panel_top_login.TabIndex = 0;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(31, 146);
            this.textBox_ID.Multiline = true;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(365, 52);
            this.textBox_ID.TabIndex = 1;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(31, 254);
            this.textBox_Password.Multiline = true;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(365, 52);
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // button_Summit
            // 
            this.button_Summit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.button_Summit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Summit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(177)))), ((int)(((byte)(176)))));
            this.button_Summit.Location = new System.Drawing.Point(31, 349);
            this.button_Summit.Name = "button_Summit";
            this.button_Summit.Size = new System.Drawing.Size(365, 51);
            this.button_Summit.TabIndex = 3;
            this.button_Summit.Text = "Summit";
            this.button_Summit.UseVisualStyleBackColor = false;
            // 
            // button_Register
            // 
            this.button_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(193)))), ((int)(((byte)(243)))));
            this.button_Register.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.button_Register.Location = new System.Drawing.Point(31, 434);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(365, 51);
            this.button_Register.TabIndex = 4;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = false;
            // 
            // label_Login
            // 
            this.label_Login.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.label_Login.Location = new System.Drawing.Point(31, 9);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(365, 75);
            this.label_Login.TabIndex = 0;
            this.label_Login.Text = "LOGIN";
            this.label_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(431, 543);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.button_Summit);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.panel_top_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.panel_top_login.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top_login;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Summit;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Label label_Login;
    }
}

