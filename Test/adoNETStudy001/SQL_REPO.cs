using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adoNETStudy001
{
    public class SQL_REPO
    {

        

        /// <summary>
        /// 생성자
        /// </summary>
        public SQL_REPO()
        {
            
        }

        /// <summary>
        /// 조회 DataSet 을 반환
        /// </summary>
        /// <param name="strConnectionName">SQL 커넥션 명</param>
        /// <param name="strSPName"></param>
        /// <param name="arrParamNames"></param>
        /// <returns></returns>
        public DataSet ExecuteFillDataSet(string strSPName, Dictionary<string, object> arrParamNames)
        {
            DataSet dsResult = new DataSet();

            SQL_INFO info = new SQL_INFO();

            using (SqlConnection connection = info.getConnection())
            {
                
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(strSPName, connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 30;
                    sqlCommand.Parameters.AddRange(ToSqlParams(arrParamNames));

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                    dataAdapter.Fill(dsResult);

                }
                
            }

            return dsResult;

        }

        /// <summary>
        /// Dictionary<string, object> 형식을 Sql 파라미터로 변환
        /// </summary>
        /// <param name="arrParamNames">파라미터 내용</param>
        /// <returns></returns>
        public static SqlParameter[] ToSqlParams(Dictionary<string, object> arrParamNames)
        {
            SqlParameter[] sqlParameters = new SqlParameter[arrParamNames.Count];
            int i = 0;
            foreach (KeyValuePair<string, object> item in arrParamNames)
            {
                sqlParameters[i] = new SqlParameter();
                sqlParameters[i].ParameterName = item.Key;
                sqlParameters[i].Value = item.Value;

                i += 1;
            }

            return sqlParameters;

        }


    }
}
