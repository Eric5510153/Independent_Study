using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace TIDIP_ADO_NET_V2.Models
{
    public class GetData
    {
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TIDIP_V2Connection"].ConnectionString);

        SqlCommand cmd = new SqlCommand("", conn);
        SqlDataReader rd;


        //
        SqlDataAdapter adp = new SqlDataAdapter("", conn);

        DataSet ds = new DataSet();
        DataTable dt = new DataTable();


        public DataTable TableQuery(string sql)
        {
            adp.SelectCommand.CommandText = sql;  //指定 Select Command
            adp.Fill(ds);  //把取到的Table填入DataSet

            dt = ds.Tables[0];

            return dt;
        }
       

        public DataTable TableQuery(string sql, List<SqlParameter> para)
        {
            adp.SelectCommand.CommandText = sql;  //指定 Select Command

            foreach (SqlParameter p in para)
            {
                adp.SelectCommand.Parameters.Add(p);
            }

            adp.Fill(ds);  //把取到的Table填入DataSet

            dt = ds.Tables[0];

            return dt;
        }


        public DataTable TableQueryBySP(string sql)
        {
            adp.SelectCommand.CommandText = sql;  //指定 Select Command
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            adp.Fill(ds);  //把取到的Table填入DataSet

            dt = ds.Tables[0];

            return dt;
        }

        public DataTable TableQueryBySP(string sql, List<SqlParameter> para)
        {
            adp.SelectCommand.CommandText = sql;  //指定 Select Command
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter p in para)
            {
                adp.SelectCommand.Parameters.Add(p);
            }

            adp.Fill(ds);  //把取到的Table填入DataSet

            if (ds.Tables.Count == 0)
                return dt;

            dt = ds.Tables[0];

            return dt;
        }

        public SqlDataReader LoginQuery(string sql, List<SqlParameter> para)
        {
            cmd.CommandText = sql;

            foreach (SqlParameter p in para)
            {
                cmd.Parameters.Add(p);
            }

            conn.Open();
            try
            {
                rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                rd.Read();
                //int i= 0;
                //i = 1 / i;
            }
            catch
            {
                conn.Close();
            }

            return rd;

        }
    }
}