
namespace DBMS_project
{
    partial class Form_Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Booking));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.pictureBox_poster = new System.Windows.Forms.PictureBox();
            this.pictureBox_Avata = new System.Windows.Forms.PictureBox();
            this.panel_Fill = new System.Windows.Forms.Panel();
            this.label_MovieName = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Arthur = new System.Windows.Forms.Label();
            this.textBox_Arthur = new System.Windows.Forms.TextBox();
            this.label_Type = new System.Windows.Forms.Label();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.label_TTime = new System.Windows.Forms.Label();
            this.textBox_TTime = new System.Windows.Forms.TextBox();
            this.button_Room1 = new System.Windows.Forms.Button();
            this.button_Room2 = new System.Windows.Forms.Button();
            this.label_Description = new System.Windows.Forms.Label();
            this.richTextBox_Description = new System.Windows.Forms.RichTextBox();
            this.panel_Top.SuspendLayout();
            this.panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_poster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Avata)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel_Top.Controls.Add(this.richTextBox_Description);
            this.panel_Top.Controls.Add(this.label_Description);
            this.panel_Top.Controls.Add(this.button_Room2);
            this.panel_Top.Controls.Add(this.button_Room1);
            this.panel_Top.Controls.Add(this.textBox_TTime);
            this.panel_Top.Controls.Add(this.label_TTime);
            this.panel_Top.Controls.Add(this.textBox_Type);
            this.panel_Top.Controls.Add(this.label_Type);
            this.panel_Top.Controls.Add(this.textBox_Arthur);
            this.panel_Top.Controls.Add(this.label_Arthur);
            this.panel_Top.Controls.Add(this.textBox_Name);
            this.panel_Top.Controls.Add(this.label_MovieName);
            this.panel_Top.Controls.Add(this.pictureBox_Avata);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1172, 192);
            this.panel_Top.TabIndex = 0;
            // 
            // panel_Left
            // 
            this.panel_Left.Controls.Add(this.pictureBox_poster);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 192);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(434, 552);
            this.panel_Left.TabIndex = 1;
            // 
            // pictureBox_poster
            // 
            this.pictureBox_poster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_poster.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_poster.Image")));
            this.pictureBox_poster.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_poster.Name = "pictureBox_poster";
            this.pictureBox_poster.Size = new System.Drawing.Size(434, 552);
            this.pictureBox_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_poster.TabIndex = 0;
            this.pictureBox_poster.TabStop = false;
            // 
            // pictureBox_Avata
            // 
            this.pictureBox_Avata.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Avata.Image")));
            this.pictureBox_Avata.Location = new System.Drawing.Point(78, 12);
            this.pictureBox_Avata.Name = "pictureBox_Avata";
            this.pictureBox_Avata.Size = new System.Drawing.Size(166, 162);
            this.pictureBox_Avata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Avata.TabIndex = 0;
            this.pictureBox_Avata.TabStop = false;
            this.pictureBox_Avata.Click += new System.EventHandler(this.pictureBox_Avata_Click);
            // 
            // panel_Fill
            // 
            this.panel_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Fill.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Fill.Location = new System.Drawing.Point(434, 192);
            this.panel_Fill.Name = "panel_Fill";
            this.panel_Fill.Size = new System.Drawing.Size(738, 552);
            this.panel_Fill.TabIndex = 2;
            this.panel_Fill.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Fill_Paint);
            // 
            // label_MovieName
            // 
            this.label_MovieName.AutoSize = true;
            this.label_MovieName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MovieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label_MovieName.Location = new System.Drawing.Point(270, 28);
            this.label_MovieName.Name = "label_MovieName";
            this.label_MovieName.Size = new System.Drawing.Size(65, 23);
            this.label_MovieName.TabIndex = 1;
            this.label_MovieName.Text = "Name: ";
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox_Name.Location = new System.Drawing.Point(341, 28);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 23);
            this.textBox_Name.TabIndex = 2;
            this.textBox_Name.Text = "Mắt Biếc";
            // 
            // label_Arthur
            // 
            this.label_Arthur.AutoSize = true;
            this.label_Arthur.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Arthur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label_Arthur.Location = new System.Drawing.Point(270, 63);
            this.label_Arthur.Name = "label_Arthur";
            this.label_Arthur.Size = new System.Drawing.Size(69, 23);
            this.label_Arthur.TabIndex = 3;
            this.label_Arthur.Text = "Arthur: ";
            // 
            // textBox_Arthur
            // 
            this.textBox_Arthur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.textBox_Arthur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Arthur.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Arthur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox_Arthur.Location = new System.Drawing.Point(341, 63);
            this.textBox_Arthur.Name = "textBox_Arthur";
            this.textBox_Arthur.Size = new System.Drawing.Size(100, 23);
            this.textBox_Arthur.TabIndex = 4;
            this.textBox_Arthur.Text = "Victor Vũ";
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label_Type.Location = new System.Drawing.Point(270, 101);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(55, 23);
            this.label_Type.TabIndex = 5;
            this.label_Type.Text = "Type: ";
            // 
            // textBox_Type
            // 
            this.textBox_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.textBox_Type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Type.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox_Type.Location = new System.Drawing.Point(341, 101);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(100, 23);
            this.textBox_Type.TabIndex = 6;
            this.textBox_Type.Text = "Romance";
            // 
            // label_TTime
            // 
            this.label_TTime.AutoSize = true;
            this.label_TTime.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label_TTime.Location = new System.Drawing.Point(270, 135);
            this.label_TTime.Name = "label_TTime";
            this.label_TTime.Size = new System.Drawing.Size(97, 23);
            this.label_TTime.TabIndex = 7;
            this.label_TTime.Text = "Total Time: ";
            // 
            // textBox_TTime
            // 
            this.textBox_TTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.textBox_TTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_TTime.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox_TTime.Location = new System.Drawing.Point(373, 135);
            this.textBox_TTime.Name = "textBox_TTime";
            this.textBox_TTime.Size = new System.Drawing.Size(100, 23);
            this.textBox_TTime.TabIndex = 8;
            this.textBox_TTime.Text = "90 minutes ";
            // 
            // button_Room1
            // 
            this.button_Room1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.button_Room1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.button_Room1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.button_Room1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.button_Room1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Room1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Room1.Location = new System.Drawing.Point(1097, 136);
            this.button_Room1.Name = "button_Room1";
            this.button_Room1.Size = new System.Drawing.Size(75, 56);
            this.button_Room1.TabIndex = 9;
            this.button_Room1.Text = "Room 1";
            this.button_Room1.UseVisualStyleBackColor = false;
            this.button_Room1.Click += new System.EventHandler(this.button_Room1_Click);
            this.button_Room1.MouseHover += new System.EventHandler(this.button_Room1_MouseHover);
            // 
            // button_Room2
            // 
            this.button_Room2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.button_Room2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.button_Room2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.button_Room2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.button_Room2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Room2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Room2.Location = new System.Drawing.Point(1016, 136);
            this.button_Room2.Name = "button_Room2";
            this.button_Room2.Size = new System.Drawing.Size(75, 56);
            this.button_Room2.TabIndex = 10;
            this.button_Room2.Text = "Room 2";
            this.button_Room2.UseVisualStyleBackColor = false;
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label_Description.Location = new System.Drawing.Point(500, 28);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(96, 23);
            this.label_Description.TabIndex = 11;
            this.label_Description.Text = "Description";
            // 
            // richTextBox_Description
            // 
            this.richTextBox_Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.richTextBox_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.richTextBox_Description.Location = new System.Drawing.Point(504, 54);
            this.richTextBox_Description.Name = "richTextBox_Description";
            this.richTextBox_Description.Size = new System.Drawing.Size(476, 120);
            this.richTextBox_Description.TabIndex = 12;
            this.richTextBox_Description.Text = resources.GetString("richTextBox_Description.Text");
            // 
            // Form_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 744);
            this.Controls.Add(this.panel_Fill);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.panel_Top);
            this.Name = "Form_Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_poster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Avata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.PictureBox pictureBox_Avata;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.PictureBox pictureBox_poster;
        private System.Windows.Forms.Button button_Room1;
        private System.Windows.Forms.TextBox textBox_TTime;
        private System.Windows.Forms.Label label_TTime;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.TextBox textBox_Arthur;
        private System.Windows.Forms.Label label_Arthur;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_MovieName;
        private System.Windows.Forms.Panel panel_Fill;
        private System.Windows.Forms.RichTextBox richTextBox_Description;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Button button_Room2;
    }
}