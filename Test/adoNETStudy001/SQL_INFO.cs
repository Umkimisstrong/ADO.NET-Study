using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adoNETStudy001
{
    public class SQL_INFO
    {

        public string strSqlConnection = string.Empty;
        public SqlConnection sqlConnection = null;

        /// <summary>
        /// 생성자
        /// </summary>
        public SQL_INFO()
        {
            strSqlConnection = "Data Source=DESKTOP-DQ5BA59;Initial Catalog=CENTERO; User ID=local_ksk; Password=rlatkdrl123!;";
        }


        /// <summary>
        /// 생성자(SQL 커넥션 지정)
        /// </summary>
        /// <param name="strSqlConnection">커넥션 문자열</param>
        public SQL_INFO(string strSqlConnection)
        {
            this.strSqlConnection = strSqlConnection;
        }

        public SqlConnection getConnection()
        {
            if(sqlConnection == null)
            {
                sqlConnection = new SqlConnection();
            }

            // getting SQL Connection use sqlConnection

            sqlConnection.ConnectionString = this.strSqlConnection;


            return sqlConnection;
        }

    }
}
