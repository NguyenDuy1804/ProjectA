﻿using System;
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
    public partial class Form_Bill : Form
    {
        public Form_Bill()
        {
            InitializeComponent();
        }

        private void textBox_EmpID_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (textBox_EmpID.Text != "")
                    {
                        textBox_EmpName.Text = BUS.Instance.GetEmployeeName(textBox_EmpID.Text);
                    }
                }
                else textBox_EmpName.Text = "";
            }
            catch (Exception ex)
            {
                textBox_EmpName.Text = "";
                ex = new Exception("ID không tồn tại");
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
