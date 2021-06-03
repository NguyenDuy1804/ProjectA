﻿using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Linq; using System.Text; using System.Threading.Tasks; using System.Windows.Forms;  namespace DBMS_project {     public partial class Form_Employee : Form     {         public Form_Employee()         {             InitializeComponent();         }          private void button_CreateRP_Click(object sender, EventArgs e)         {             SaveFileDialog sfd = new SaveFileDialog();             sfd.Filter = "Word Documents (*.doc)|*.doc";             sfd.FileName = "";              if (sfd.ShowDialog() == DialogResult.OK)             {                 BUS.Instance.Export(dataGridView1, sfd.FileName);             }         }          private void Form_Employee_Load(object sender, EventArgs e)         {             BUS.Instance.Load(dataGridView1);         }

        private void pn_top_Employee_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Data_Employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = DAO.Instance.searchEmployeeByID(textBoxSearch.Text);
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("ID Employee not exist!");
                BUS.Instance.Load(dataGridView1);
            }
        }
    } } 