using System;
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

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        bool checkacc() //Hàm check username và password, nếu return true thì username và password đúng, và ngược lại.
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=NP119411\SQLEXPRESS;Initial Catalog=quanlyrapphim;Integrated Security=True"; //Kết nối server SQL, muốn chạy thử bên máy mày phải đổi đường dẫn server
            cnn = new SqlConnection(connetionString);
            string cmdstring = string.Format("select username, password from Account where username = '{0}' and password = '{1}'", tk.Text , textBox_Password.Text); //lấy username và password từ SQL
            SqlCommand cmd = new SqlCommand(cmdstring, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cnn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            if (dt.Rows.Count > 0)
            {
                return true;    // Hàm trả về
            }
            else
            return false;       // Hàm trả về
        }
    
        //void dk()                               //Hàm đăng ký, chưa sử dụng
        //{
        //    string connetionString;
        //    SqlConnection cnn;
        //    connetionString = @"Data Source=NP119411\SQLEXPRESS;Initial Catalog=quanlyrapphim;Integrated Security=True";
        //    cnn = new SqlConnection(connetionString);
        //    string cmdstring = string.Format(" username = '{0}' and password = '{1}'", tk.Text, textBox_Password.Text);
        //    SqlCommand cmd = new SqlCommand(cmdstring, cnn);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    cnn.Open();
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    cnn.Close();
        //}
        private void button_Summit_Click(object sender, EventArgs e)
        {
            if (checkacc() == true)
            {
                Dashboard frm = new Dashboard();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Sai tai khoan hoac mat khau. Vui long nhap lai!");

        }
    }
}

