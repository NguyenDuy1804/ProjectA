
namespace DBMS_project
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel_RightDB = new System.Windows.Forms.Panel();
            this.label_Dashboard = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.chart_Movie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Revenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_Report = new System.Windows.Forms.Panel();
            this.button_CreateRP = new System.Windows.Forms.Button();
            this.label_RPDB = new System.Windows.Forms.Label();
            this.btEmployee = new System.Windows.Forms.Button();
            this.pnBt_Employee = new System.Windows.Forms.Panel();
            this.bt_Movie = new System.Windows.Forms.Button();
            this.btDashboard = new System.Windows.Forms.Button();
            this.bt_Booking = new System.Windows.Forms.Button();
            this.bt_Bill = new System.Windows.Forms.Button();
            this.pnBt_Movie = new System.Windows.Forms.Panel();
            this.pnBt_Dashboard = new System.Windows.Forms.Panel();
            this.pnBt_Booking = new System.Windows.Forms.Panel();
            this.pnBT_Bill = new System.Windows.Forms.Panel();
            this.panel_RightDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Movie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Revenue)).BeginInit();
            this.panel_Report.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_RightDB
            // 
            this.panel_RightDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel_RightDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_RightDB.Controls.Add(this.pnBT_Bill);
            this.panel_RightDB.Controls.Add(this.pnBt_Booking);
            this.panel_RightDB.Controls.Add(this.pnBt_Dashboard);
            this.panel_RightDB.Controls.Add(this.pnBt_Movie);
            this.panel_RightDB.Controls.Add(this.bt_Bill);
            this.panel_RightDB.Controls.Add(this.bt_Booking);
            this.panel_RightDB.Controls.Add(this.btDashboard);
            this.panel_RightDB.Controls.Add(this.bt_Movie);
            this.panel_RightDB.Controls.Add(this.pnBt_Employee);
            this.panel_RightDB.Controls.Add(this.btEmployee);
            this.panel_RightDB.Controls.Add(this.label_Dashboard);
            this.panel_RightDB.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_RightDB.Location = new System.Drawing.Point(0, 0);
            this.panel_RightDB.Name = "panel_RightDB";
            this.panel_RightDB.Size = new System.Drawing.Size(239, 792);
            this.panel_RightDB.TabIndex = 0;
            // 
            // label_Dashboard
            // 
            this.label_Dashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Dashboard.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.label_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.label_Dashboard.Name = "label_Dashboard";
            this.label_Dashboard.Size = new System.Drawing.Size(237, 133);
            this.label_Dashboard.TabIndex = 0;
            this.label_Dashboard.Text = "DASHBOARD";
            this.label_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Top
            // 
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(239, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1190, 94);
            this.panel_Top.TabIndex = 1;
            // 
            // chart_Movie
            // 
            this.chart_Movie.BackColor = System.Drawing.SystemColors.Window;
            chartArea9.Name = "ChartArea1";
            this.chart_Movie.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart_Movie.Legends.Add(legend9);
            this.chart_Movie.Location = new System.Drawing.Point(1014, 227);
            this.chart_Movie.Name = "chart_Movie";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart_Movie.Series.Add(series9);
            this.chart_Movie.Size = new System.Drawing.Size(374, 512);
            this.chart_Movie.TabIndex = 7;
            this.chart_Movie.Text = "chart1";
            // 
            // chart_Revenue
            // 
            chartArea10.Name = "ChartArea1";
            this.chart_Revenue.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart_Revenue.Legends.Add(legend10);
            this.chart_Revenue.Location = new System.Drawing.Point(258, 227);
            this.chart_Revenue.Name = "chart_Revenue";
            this.chart_Revenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series10.ChartArea = "ChartArea1";
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            series10.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            series10.ShadowOffset = 4;
            this.chart_Revenue.Series.Add(series10);
            this.chart_Revenue.Size = new System.Drawing.Size(736, 512);
            this.chart_Revenue.TabIndex = 6;
            this.chart_Revenue.Text = "Revenue";
            // 
            // panel_Report
            // 
            this.panel_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.panel_Report.Controls.Add(this.button_CreateRP);
            this.panel_Report.Controls.Add(this.label_RPDB);
            this.panel_Report.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Report.Location = new System.Drawing.Point(239, 94);
            this.panel_Report.Name = "panel_Report";
            this.panel_Report.Size = new System.Drawing.Size(1190, 198);
            this.panel_Report.TabIndex = 5;
            // 
            // button_CreateRP
            // 
            this.button_CreateRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.button_CreateRP.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CreateRP.ForeColor = System.Drawing.Color.DarkGray;
            this.button_CreateRP.Location = new System.Drawing.Point(910, 19);
            this.button_CreateRP.Name = "button_CreateRP";
            this.button_CreateRP.Size = new System.Drawing.Size(208, 65);
            this.button_CreateRP.TabIndex = 1;
            this.button_CreateRP.Text = "Create report";
            this.button_CreateRP.UseVisualStyleBackColor = false;
            // 
            // label_RPDB
            // 
            this.label_RPDB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RPDB.Location = new System.Drawing.Point(23, 19);
            this.label_RPDB.Name = "label_RPDB";
            this.label_RPDB.Size = new System.Drawing.Size(207, 44);
            this.label_RPDB.TabIndex = 0;
            this.label_RPDB.Text = "Dashboard";
            this.label_RPDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btEmployee
            // 
            this.btEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btEmployee.FlatAppearance.BorderSize = 0;
            this.btEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.btEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmployee.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btEmployee.Location = new System.Drawing.Point(0, 218);
            this.btEmployee.Name = "btEmployee";
            this.btEmployee.Size = new System.Drawing.Size(234, 61);
            this.btEmployee.TabIndex = 1;
            this.btEmployee.Text = "Employee";
            this.btEmployee.UseVisualStyleBackColor = false;
            this.btEmployee.Click += new System.EventHandler(this.btEmployee_Click);
            // 
            // pnBt_Employee
            // 
            this.pnBt_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.pnBt_Employee.Location = new System.Drawing.Point(-2, 218);
            this.pnBt_Employee.Name = "pnBt_Employee";
            this.pnBt_Employee.Size = new System.Drawing.Size(7, 61);
            this.pnBt_Employee.TabIndex = 2;
            this.pnBt_Employee.Visible = false;
            // 
            // bt_Movie
            // 
            this.bt_Movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.bt_Movie.FlatAppearance.BorderSize = 0;
            this.bt_Movie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.bt_Movie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Movie.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Movie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.bt_Movie.Location = new System.Drawing.Point(0, 285);
            this.bt_Movie.Name = "bt_Movie";
            this.bt_Movie.Size = new System.Drawing.Size(235, 61);
            this.bt_Movie.TabIndex = 3;
            this.bt_Movie.Text = "Movie";
            this.bt_Movie.UseVisualStyleBackColor = false;
            this.bt_Movie.Click += new System.EventHandler(this.bt_Movie_Click);
            // 
            // btDashboard
            // 
            this.btDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btDashboard.FlatAppearance.BorderSize = 0;
            this.btDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.btDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDashboard.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btDashboard.Location = new System.Drawing.Point(-1, 352);
            this.btDashboard.Name = "btDashboard";
            this.btDashboard.Size = new System.Drawing.Size(238, 61);
            this.btDashboard.TabIndex = 5;
            this.btDashboard.Text = "Dashboard";
            this.btDashboard.UseVisualStyleBackColor = false;
            this.btDashboard.Click += new System.EventHandler(this.btDashboard_Click);
            // 
            // bt_Booking
            // 
            this.bt_Booking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.bt_Booking.FlatAppearance.BorderSize = 0;
            this.bt_Booking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.bt_Booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Booking.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Booking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.bt_Booking.Location = new System.Drawing.Point(-4, 419);
            this.bt_Booking.Name = "bt_Booking";
            this.bt_Booking.Size = new System.Drawing.Size(238, 61);
            this.bt_Booking.TabIndex = 7;
            this.bt_Booking.Text = "Booking";
            this.bt_Booking.UseVisualStyleBackColor = false;
            this.bt_Booking.Click += new System.EventHandler(this.bt_Booking_Click);
            // 
            // bt_Bill
            // 
            this.bt_Bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.bt_Bill.FlatAppearance.BorderSize = 0;
            this.bt_Bill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.bt_Bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Bill.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Bill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.bt_Bill.Location = new System.Drawing.Point(0, 486);
            this.bt_Bill.Name = "bt_Bill";
            this.bt_Bill.Size = new System.Drawing.Size(238, 61);
            this.bt_Bill.TabIndex = 9;
            this.bt_Bill.Text = "Bill";
            this.bt_Bill.UseVisualStyleBackColor = false;
            this.bt_Bill.Click += new System.EventHandler(this.bt_Bill_Click);
            // 
            // pnBt_Movie
            // 
            this.pnBt_Movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.pnBt_Movie.Location = new System.Drawing.Point(-2, 285);
            this.pnBt_Movie.Name = "pnBt_Movie";
            this.pnBt_Movie.Size = new System.Drawing.Size(7, 61);
            this.pnBt_Movie.TabIndex = 10;
            this.pnBt_Movie.Visible = false;
            // 
            // pnBt_Dashboard
            // 
            this.pnBt_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.pnBt_Dashboard.Location = new System.Drawing.Point(-2, 352);
            this.pnBt_Dashboard.Name = "pnBt_Dashboard";
            this.pnBt_Dashboard.Size = new System.Drawing.Size(7, 61);
            this.pnBt_Dashboard.TabIndex = 11;
            this.pnBt_Dashboard.Visible = false;
            // 
            // pnBt_Booking
            // 
            this.pnBt_Booking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.pnBt_Booking.Location = new System.Drawing.Point(-2, 419);
            this.pnBt_Booking.Name = "pnBt_Booking";
            this.pnBt_Booking.Size = new System.Drawing.Size(7, 61);
            this.pnBt_Booking.TabIndex = 12;
            this.pnBt_Booking.Visible = false;
            // 
            // pnBT_Bill
            // 
            this.pnBT_Bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.pnBT_Bill.Location = new System.Drawing.Point(-2, 486);
            this.pnBT_Bill.Name = "pnBT_Bill";
            this.pnBT_Bill.Size = new System.Drawing.Size(7, 61);
            this.pnBT_Bill.TabIndex = 13;
            this.pnBT_Bill.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1429, 792);
            this.Controls.Add(this.chart_Movie);
            this.Controls.Add(this.chart_Revenue);
            this.Controls.Add(this.panel_Report);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_RightDB);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dashboard";
            this.panel_RightDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Movie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Revenue)).EndInit();
            this.panel_Report.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_RightDB;
        private System.Windows.Forms.Label label_Dashboard;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel pnBt_Employee;
        private System.Windows.Forms.Button btEmployee;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Movie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Revenue;
        private System.Windows.Forms.Panel panel_Report;
        private System.Windows.Forms.Button button_CreateRP;
        private System.Windows.Forms.Label label_RPDB;
        private System.Windows.Forms.Button bt_Bill;
        private System.Windows.Forms.Button bt_Booking;
        private System.Windows.Forms.Button btDashboard;
        private System.Windows.Forms.Button bt_Movie;
        private System.Windows.Forms.Panel pnBT_Bill;
        private System.Windows.Forms.Panel pnBt_Booking;
        private System.Windows.Forms.Panel pnBt_Dashboard;
        private System.Windows.Forms.Panel pnBt_Movie;
    }
}