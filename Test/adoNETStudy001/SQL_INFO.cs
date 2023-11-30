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

        public string sqlConnection = string.Empty;


        /// <summary>
        /// 생성자
        /// </summary>
        public SQL_INFO()
        {
            sqlConnection = "connection";
        }


        /// <summary>
        /// 생성자(SQL 커넥션 지정)
        /// </summary>
        /// <param name="strSqlConnection">커넥션 문자열</param>
        public SQL_INFO(string strSqlConnection)
        {
            this.sqlConnection = strSqlConnection;
        }

        public SqlConnection getConnection()
        {
            SqlConnection connection = null;

            // getting SQL Connection use sqlConnection



            return connection;
        }

    }
}
