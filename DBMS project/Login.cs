﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_project
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        public static int permission = 1;
        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void button_Summit_Click(object sender, EventArgs e)
        {
            if (BUS.Instance.Login(tbx_userName, tbx_Password))
            {
                if (rbtn_Manager.Checked)
                {
                    Form_Employee frm = new Form_Employee();
                    frm.Show();
                    this.Hide();
                }
                else if (rbtn_Employee.Checked)
                {
                    Form_Booking frm = new Form_Booking();
                    frm.Show();
                    this.Hide();
                }
                else MessageBox.Show("Tài khoản không có quyền!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu. Vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void rbtn_Manager_CheckedChanged(object sender, EventArgs e)
        {
            permission = 1;
        }

        private void rbtn_Employee_CheckedChanged(object sender, EventArgs e)
        {
            permission = 2;
        }
    }
}

