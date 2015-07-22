using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace dal
{
    public class dbService
    {
        SQLHelper sqlHelper = new SQLHelper();
        public bool BackupDb(string bkpath)
        {   // 完整备份
            SqlParameter[] paras = { new SqlParameter("@bakFile", bkpath) };
            sqlHelper.ExeCmd("insert into db_bakfile(bakFile,bakType) values(@bakFile,'完全备份')", CommandType.Text, paras);
            return sqlHelper.ExeCmd("backup database VXer to disk = '" + bkpath + "'", CommandType.Text);
        }
        public bool BackupDifrtDb(string bkpath)
        {   // 差异备份
            SqlParameter[] paras = { new SqlParameter("@bakFile", bkpath) };
            sqlHelper.ExeCmd("insert into db_bakfile(bakFile,bakType) values(@bakFile,'差异备份')", CommandType.Text, paras);
            return sqlHelper.ExeCmd("backup database VXer to disk = '" + bkpath + "' with differential", CommandType.Text);
        }
        public bool ResumeDb(string bkpath)
        {
            return sqlHelper.ExeCmd("use master restore database VXer from disk = '" + bkpath + "' WITH REPLACE", CommandType.Text);
        }
        public DataTable GetAllbaks()
        {
            return sqlHelper.GetTab("select * from db_bakfile order by createTime desc", CommandType.Text);
        }
        public bool DelBak(int id)
        {
            SqlParameter[] paras = { new SqlParameter("@id", id) };
            return sqlHelper.ExeCmd("delete from db_bakfile where id = @id", CommandType.Text, paras);
        }
    }
}
