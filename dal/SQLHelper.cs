using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace dal
{
    public class SQLHelper
    {
        public SqlConnection GetConn()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["strConn"].ToString());
        }

        public object ExeScl(string cmdText, CommandType cmdType)
        {
            SqlConnection conn = GetConn();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            cmd.CommandType = cmdType;
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch
            {
                return null;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public object ExeScl(string cmdText, CommandType cmdType, SqlParameter[] paras)
        {
            SqlConnection conn = GetConn();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            cmd.CommandType = cmdType;
            cmd.Parameters.AddRange(paras);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch
            {
                return null;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public DataTable GetTab(string cmdText, CommandType cmdType)
        {
            DataTable tab = new DataTable();
            SqlConnection conn = GetConn();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            cmd.CommandType = cmdType;
            try
            {
                conn.Open();
                tab.Load(cmd.ExecuteReader());
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return tab;
        }

        public DataTable GetTab(string cmdText, CommandType cmdType, SqlParameter[] paras)
        {
            DataTable tab = new DataTable();
            SqlConnection conn = GetConn();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            cmd.CommandType = cmdType;
            cmd.Parameters.AddRange(paras);
            try
            {
                conn.Open();
                tab.Load(cmd.ExecuteReader());
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return tab;
        }

        public bool ExeCmd(string cmdText, CommandType cmdType)
        {
            SqlConnection conn = GetConn();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            cmd.CommandType = cmdType;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public bool ExeCmd(string cmdText, CommandType cmdType, SqlParameter[] paras)
        {
            SqlConnection conn = GetConn();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            cmd.CommandType = cmdType;
            cmd.Parameters.AddRange(paras);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }


        public bool BatExec(string[] cmdText, CommandType cmdType, SqlParameter[] paras)
        {
            SqlConnection conn = GetConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = cmdType;
            cmd.Parameters.AddRange(paras);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
    }
}
