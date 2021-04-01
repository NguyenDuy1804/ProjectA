
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel_RightDB = new System.Windows.Forms.Panel();
            this.label_Dashboard = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel_Report = new System.Windows.Forms.Panel();
            this.label_RPDB = new System.Windows.Forms.Label();
            this.button_CreateRP = new System.Windows.Forms.Button();
            this.chart_Revenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Movie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_RightDB.SuspendLayout();
            this.panel_Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Revenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Movie)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_RightDB
            // 
            this.panel_RightDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel_RightDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_RightDB.Controls.Add(this.label_Dashboard);
            this.panel_RightDB.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_RightDB.Location = new System.Drawing.Point(0, 0);
            this.panel_RightDB.Name = "panel_RightDB";
            this.panel_RightDB.Size = new System.Drawing.Size(222, 792);
            this.panel_RightDB.TabIndex = 0;
            // 
            // label_Dashboard
            // 
            this.label_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Dashboard.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.label_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.label_Dashboard.Name = "label_Dashboard";
            this.label_Dashboard.Size = new System.Drawing.Size(220, 133);
            this.label_Dashboard.TabIndex = 0;
            this.label_Dashboard.Text = "DASHBOARD";
            this.label_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Top
            // 
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(222, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1187, 94);
            this.panel_Top.TabIndex = 1;
            // 
            // panel_Report
            // 
            this.panel_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            this.panel_Report.Controls.Add(this.button_CreateRP);
            this.panel_Report.Controls.Add(this.label_RPDB);
            this.panel_Report.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Report.Location = new System.Drawing.Point(222, 94);
            this.panel_Report.Name = "panel_Report";
            this.panel_Report.Size = new System.Drawing.Size(1187, 198);
            this.panel_Report.TabIndex = 2;
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
            // button_CreateRP
            // 
            this.button_CreateRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.button_CreateRP.Location = new System.Drawing.Point(953, 19);
            this.button_CreateRP.Name = "button_CreateRP";
            this.button_CreateRP.Size = new System.Drawing.Size(208, 65);
            this.button_CreateRP.TabIndex = 1;
            this.button_CreateRP.Text = "Create report";
            this.button_CreateRP.UseVisualStyleBackColor = false;
            // 
            // chart_Revenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Revenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Revenue.Legends.Add(legend1);
            this.chart_Revenue.Location = new System.Drawing.Point(251, 268);
            this.chart_Revenue.Name = "chart_Revenue";
            this.chart_Revenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            series1.ShadowOffset = 4;
            this.chart_Revenue.Series.Add(series1);
            this.chart_Revenue.Size = new System.Drawing.Size(736, 512);
            this.chart_Revenue.TabIndex = 3;
            this.chart_Revenue.Text = "Revenue";
            // 
            // chart_Movie
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_Movie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_Movie.Legends.Add(legend2);
            this.chart_Movie.Location = new System.Drawing.Point(1009, 268);
            this.chart_Movie.Name = "chart_Movie";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(197)))), ((int)(((byte)(177)))));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_Movie.Series.Add(series2);
            this.chart_Movie.Size = new System.Drawing.Size(374, 512);
            this.chart_Movie.TabIndex = 4;
            this.chart_Movie.Text = "chart1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1409, 792);
            this.Controls.Add(this.chart_Movie);
            this.Controls.Add(this.chart_Revenue);
            this.Controls.Add(this.panel_Report);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_RightDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dashboard";
            this.panel_RightDB.ResumeLayout(false);
            this.panel_Report.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Revenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Movie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_RightDB;
        private System.Windows.Forms.Label label_Dashboard;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Report;
        private System.Windows.Forms.Button button_CreateRP;
        private System.Windows.Forms.Label label_RPDB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Revenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Movie;
    }
}