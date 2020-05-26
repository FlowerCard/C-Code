using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace _15黄子豪sy6_2
{
    class DataBaseClient
    {
        private static SqlConnection sqlCon = new SqlConnection(
            ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);

        private DataBaseClient() { }

        ~DataBaseClient()
        {
            Dispose();
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public static void Dispose()
        {
            if(sqlCon != null)
            {
                //确认连接是否已经关闭
                sqlCon.Dispose();
                sqlCon = null;
            }
        }

        /// <summary>
        /// 打开链接
        /// </summary>
        public static void Open()
        {
            if(sqlCon.State == ConnectionState.Closed)
            {
                try
                {
                    sqlCon.Open();
                }catch(Exception e)
                {
                    throw e;
                }
            }
        }

        /// <summary>
        /// 关闭链接
        /// </summary>
        public static void Close()
        {
            while(sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        /// <summary>
        /// 执行查询语句或存储过程并返回受影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql)
        {
            return ExecuteNonQuery(sql);
        }

        //public static int ExecuteNonQuery(string sql,params SqlParameter[] parameters)
        //{
        //    int returnValue;
        //    SqlCommand cmd = new SqlCommand(sql, sqlCon);
        //    if(sql.ToLower().StartsWith("insert ")||sql.ToLower().StartsWith("update ")||sql.ToLower().StartsWith("delete "))
        //    {
        //        cmd.CommandType = CommandType.Text;
        //    }
        //    else
        //    {
        //        cmd.CommandType = CommandType.StoredProcedure;
        //    }
        //    if (parameters != null)
        //    {

        //    }
        //}
    }
}
