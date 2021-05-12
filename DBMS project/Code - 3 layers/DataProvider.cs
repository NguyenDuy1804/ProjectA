using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_project
{
    class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
            //set => instance = value;
        }

        private DataProvider() { }
        string connectionString = @"Data Source=.\;Initial Catalog=DBMS;Integrated Security=True";


        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    string[] temp = query.Split(' ');

                    List<string> listParameters = new List<string>();
                    foreach (string item in temp)
                    {
                        if (item[0] == '@')
                            listParameters.Add(item.Replace(",", ""));
                    }

                    for (int i = 0; i < parameters.Length; i++)
                    {
                        command.Parameters.AddWithValue(listParameters[i], parameters[i]);
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(table);

                connection.Close();
            }

            return table;
        }

        public int executeNoneQuery(string query, object[] parameters = null)
        {
            int acceptedRows = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    string[] temp = query.Split(' ');

                    List<string> listParameters = new List<string>();
                    foreach (string item in temp)
                    {
                        if (item[0] == '@')
                            listParameters.Add(item.Replace(",", ""));
                    }

                    for (int i = 0; i < parameters.Length; i++)
                    {
                        command.Parameters.AddWithValue(listParameters[i], parameters[i]);
                    }
                }

                acceptedRows = command.ExecuteNonQuery();

                connection.Close();
            }

            return acceptedRows;
        }
    }
}
