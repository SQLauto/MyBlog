using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace dal
{
    public class adminService
    {
        SQLHelper sqlHelper = new SQLHelper();
        public bool CheckLogin(string userName,string password)
        {
            SqlParameter[] paras = { new SqlParameter("@userName", userName), new SqlParameter("@passWord", password) };
            if ("1" == sqlHelper.ExeScl("select count(*) from admin where userName = @userName and passWord = @passWord", CommandType.Text, paras).ToString())
                return true;
            else
                return false;
        }
    }
}
