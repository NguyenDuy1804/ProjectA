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
    public partial class Form_Employee : Form
    {
        public Form_Employee()
        {
            InitializeComponent();
        }

        private void button_CreateRP_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (*.doc)|*.doc";
            sfd.FileName = "";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BUS.Instance.Export(Data_Employee, sfd.FileName);
            }
        }

        private void Form_Employee_Load(object sender, EventArgs e)
        {
            BUS.Instance.Load(Data_Employee);
        }
    }
}
