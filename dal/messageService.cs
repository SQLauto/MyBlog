using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace dal
{
    public class messageService
    {
        SQLHelper sqlHelper = new SQLHelper();
        public DataTable GetAllMsgs()
        {
            return sqlHelper.GetTab("select * from messages", CommandType.Text);
        }
        public bool AddMsg(string userIP, string remark)
        {
            SqlParameter[] paras = { new SqlParameter("@userIP", userIP), new SqlParameter("@remark", remark) };
            return sqlHelper.ExeCmd("insert into messages(userIP,remark) values(@userIP,@remark)", CommandType.Text, paras);
        }
        public DataTable GetTopFiveMsgs()
        {
            return sqlHelper.GetTab("select top 5 * from messages", CommandType.Text);
        }
        public bool DelMsg(int id)
        {
            SqlParameter[] paras = { new SqlParameter("@id", id) };
            return sqlHelper.ExeCmd("delete from messages where id = @id", CommandType.Text, paras);
        }
    }
}
