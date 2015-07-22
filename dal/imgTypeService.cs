using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace dal
{
    public class imgTypeService
    {
        SQLHelper sqlHelper = new SQLHelper();
        public bool AddImgType(string imgType)
        {
            SqlParameter[] paras = { new SqlParameter("@imgType", imgType) };
            return sqlHelper.ExeCmd("insert into imgType(imgType) values(@imgType)", CommandType.Text, paras);
        }
        public bool DelImgType(int id)
        {
            SqlParameter[] paras = { new SqlParameter("@id", id) };
            return sqlHelper.ExeCmd("delete from imgType where id = @id", CommandType.Text, paras);
        }
        public bool UpdateImgType(int id, string imgType)
        {
            SqlParameter[] paras = {
                                       new SqlParameter("@id", id),
                                       new SqlParameter("@imgType", imgType)
                                   };
            return sqlHelper.ExeCmd("update imgType set imgType = @imgType where id = @id", CommandType.Text, paras);
        }
        public DataTable GetImgType()
        {
            return sqlHelper.GetTab("select * from imgType", CommandType.Text);
        }
        // 获取图片类别数
        public int GetTypeKinds()
        {
            return int.Parse(sqlHelper.ExeScl("select count(*) from imgType", CommandType.Text).ToString());
        }
    }
}
