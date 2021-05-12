using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_project
{
    class DAO
    {
        #region Singleton
        private static DAO instance;
        public static DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO();
                }
                return instance;
            }
            //set => instance = value;
        }
        private DAO() { }
        #endregion

        #region Events
        public DataTable Login(string userName, int per)
        {
            string query = "SELECT _Username, _Password FROM [dbo].[ACCOUNT] WHERE _Username = @userName AND _Permission = @per";

            object[] parameters = new object[] { userName, per };

            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public DataTable Load()
        {
            string query = "SELECT IDEmp AS ID, NameEmployee As 'Full Name', BirthDay AS 'Birth Day', Gender, Phone, Email," +
                " JobPosition AS Position FROM[dbo].[EMPLOYEE]";

            //object[] parameters = new object[] { <List parameters> };
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetEmployeeName(string id)
        {
            string query = "SELECT NameEmployee FROM[dbo].[EMPLOYEE] WHERE IDEmp = @id";

            object[] parameters = new object[] { id };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        #endregion
    }
}
