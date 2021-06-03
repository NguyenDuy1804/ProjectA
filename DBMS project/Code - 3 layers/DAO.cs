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
            string query = "USP_check @userName , @per";

            object[] parameters = new object[] { userName, per };

            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public DataTable Load()
        {
            string query = "USP_getAllEmployee";

            //object[] parameters = new object[] { <List parameters> };
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetEmployeeName(string id)
        {
            string query = "USP_checkEmployeeName  @id";

            object[] parameters = new object[] { id };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        #endregion


        public DataTable searchEmployeeByID(string id)
        {
            string query = "USP_searchEmployeeByID @id";
            object[] parameter = new object[] { id };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
        public DataTable GetValuesCountEmployee()
        {
            string query = "select dbo.FN_TOTALEMPLOYEE()";
            return DataProvider.Instance.ExecuteQuery(query);
            
        }


        public DataTable GetValuesCountCustomer()
        {
            string query = "select dbo.Fn_TotalCustomer()";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable getAllCustomer()
        {
            string query = "select* FROM dbo.ttkh()";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
