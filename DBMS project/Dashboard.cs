using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btEmployee_Click(object sender, EventArgs e)
        {
            pnBt_Employee.Visible = true;
            pnBt_Dashboard.Visible = false;
            pnBt_Movie.Visible = false;
            pnBt_Booking.Visible = false;
            pnBT_Bill.Visible = false;
            activeForm = loadFormIntoContentForm(activeForm, new Form_Employee(), panelContentLoad);
            

        }
        private Form activeForm = null;
        #region load data panel into destination panel
        public static Form loadFormIntoContentForm(Form activeForm, Form childForm, Panel isLoaded)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            isLoaded.Controls.Add(childForm);
            isLoaded.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            return childForm;
        }
        #endregion

        private void bt_Movie_Click(object sender, EventArgs e)
        {
            pnBt_Movie.Visible = true;
            pnBt_Employee.Visible = false;
            pnBt_Dashboard.Visible = false;            
            pnBt_Booking.Visible = false;
            pnBT_Bill.Visible = false;

            activeForm = loadFormIntoContentForm(activeForm, new Form_Movie(), panelContentLoad);

        }

        private void btDashboard_Click(object sender, EventArgs e)
        {
            pnBt_Dashboard.Visible = true;
            pnBt_Movie.Visible = false;
            pnBt_Employee.Visible = false;            
            pnBt_Booking.Visible = false;
            pnBT_Bill.Visible = false;
        }

        private void bt_Booking_Click(object sender, EventArgs e)
        {
            pnBt_Booking.Visible = true;
            pnBt_Dashboard.Visible = false;
            pnBt_Movie.Visible = false;
            pnBt_Employee.Visible = false;            
            pnBT_Bill.Visible = false;
            activeForm = loadFormIntoContentForm(activeForm, new Form_Booking(), panelContentLoad);
        }

        private void bt_Bill_Click(object sender, EventArgs e)
        {
            pnBT_Bill.Visible = true;
            pnBt_Booking.Visible = false;
            pnBt_Dashboard.Visible = false;
            pnBt_Movie.Visible = false;
            pnBt_Employee.Visible = false;
            activeForm = loadFormIntoContentForm(activeForm, new Form_Bill(), panelContentLoad);
        }

        private void label_Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void panelContentLoad_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
