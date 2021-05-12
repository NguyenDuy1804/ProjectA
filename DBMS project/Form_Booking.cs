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
    public partial class Form_Booking : Form
    {
        private Graphics g;
        public Form_Booking()
        {
            InitializeComponent();
            g = pnl_seatMap.CreateGraphics();
        }

        private void button_Room1_MouseHover(object sender, EventArgs e)
        {
            button_Room1.ForeColor = Color.White;
        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            new Form_Bill().Show();
        }

        private void pnl_seatMap_Paint(object sender, PaintEventArgs e)
        {
            BUS.Instance.CreateMap(g);
        }

        private void pnl_seatMap_MouseClick(object sender, MouseEventArgs e)
        {
            BUS.Instance.Booking(e.X, e.Y, g);
        }
    }
}
