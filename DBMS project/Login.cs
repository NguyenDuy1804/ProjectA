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
            connetionString = @"Data Source=NP119411\SQLEXPRESS;Initial Catalog=quanlirapphim;Integrated Security=True"; //Kết nối server SQL, muốn chạy thử bên máy mày phải đổi đường dẫn server
            cnn = new SqlConnection(connetionString);
            string cmdstring = string.Format("select username, password from Account where username = '{0}' and password = '{1}'", tk.Text, textBox_Password.Text); //lấy username và password từ SQL
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

        private int checkquyen()
        {
            int k;
            if (tk.Text[0] == 'm')
                k = 0;
            else if (tk.Text[0] == 'e')
                k = 1;
            else k = 2;
            return k;
        }


        private void button_Summit_Click(object sender, EventArgs e)
        {
            if (checkacc() == true)
            {
                if (checkquyen() == 0)
                {
                    Dashboard frm = new Dashboard();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else if (checkquyen() == 1)
                {
                    EDashboard arm = new EDashboard();
                    this.Hide();
                    arm.ShowDialog();
                    this.Show();
                }
                else MessageBox.Show("Tài khoản không có quyền!", "Thông Báo");
            }
            else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu. Vui lòng nhập lại!", "Thông Báo");

        }
    }
}

