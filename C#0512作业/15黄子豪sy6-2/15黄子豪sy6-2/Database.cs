using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace _15黄子豪sy6_2
{
       
    class Database
    {

        string CString = "Provider = Microsoft.Jet.OleDB.4.0;Data Source = student_course.mdb";
        OleDbConnection cnn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter oldAdapter = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        OleDbCommandBuilder cb = new OleDbCommandBuilder();
        
        public Database()
        {
            cnn.ConnectionString = CString;
            cmd.Connection = cnn;
        }

        public Database(string constring)
        {
            cnn.ConnectionString = constring;
            cmd.Connection = cnn;
        }

        public string OpenState()
        {
            cnn.Open();
            string State = cnn.State.ToString();
            cnn.Close();
            return State;
        }

        public string CloseState()
        {
            cnn.Close();
            string State = cnn.State.ToString();
            return State;
        }

        public string QuerySelect(string sql)
        {
            cmd.CommandText = sql;
            cnn.Open();
            string request = "";
            if (cmd.ExecuteScalar() == null){
                request = "用户名不能为空";
            }
            else
            {
                request = cmd.ExecuteScalar().ToString();
            }
            cnn.Close();
            return request;
        }

        public DataTable QueryTable(string sql)
        {
            ds.Reset();
            cmd.CommandText = sql;
            oldAdapter.SelectCommand = cmd;
            oldAdapter.Fill(ds, "table");
            dt = new DataTable();
            dt = ds.Tables["table"];
            return dt;
        }

        public DataTable QueryTable(string sql,string StuName,string CouName)
        {
            ds.Reset();
            string TjdbSql = sql;
            if (StuName != "" && CouName != "")
            {
                TjdbSql += "where student.sname = '" + StuName + "' and " + "course.cname='" + CouName + "'";
            }
            else if (StuName != "")
            {
                TjdbSql += "where student.sname = '" + StuName + "'";
            }
            else if (CouName != "")
            {
                TjdbSql += "where course.cname = '" + CouName + "'";
            }
            else
            {
                TjdbSql = sql;
            }

            cmd.CommandText = TjdbSql;
            oldAdapter.SelectCommand = cmd;
            oldAdapter.Fill(ds, "table");
            dt = new DataTable();
            dt = ds.Tables["table"];
            return dt;

        }

        public void UpDataTable()
        {
            //ds.Reset();
            //cmd.CommandText = sql;
            //oldAdapter.SelectCommand = cmd;
            //oldAdapter.Fill(ds, "table");
            //DataTable dt = new DataTable();
            //dt = ds.Tables["table"];
            cb.DataAdapter = oldAdapter;
            oldAdapter.Update(ds, "table");
            
        }

        public void DeDataTable(int index)
        {
            ds.Tables["table"].Rows[index].Delete();
            cb.DataAdapter = oldAdapter;
            oldAdapter.Update(ds, "table");
        }


        public void QueryInsert(string insertSql)
        {
            cmd.CommandText = insertSql;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


    }
}
