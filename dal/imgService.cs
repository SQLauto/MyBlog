using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace dal
{
    public class imgService
    {
        SQLHelper sqlHelper = new SQLHelper();
        public int AddImg(int typeId, string imgName, string imgPath)
        {
            SqlParameter[] paras = {
                                       new SqlParameter("@typeId", typeId),
                                       new SqlParameter("@imgName", imgName),
                                       new SqlParameter("@imgPath", imgPath)
                                   };
            return int.Parse(sqlHelper.ExeScl("insert into imgs(typeId,imgName,imgPath) values(@typeId,@imgName,@imgPath)", CommandType.Text, paras).ToString());
        }

        public int GetImgCounts()
        {
            return int.Parse(sqlHelper.ExeScl("select count(*) from imgs", CommandType.Text).ToString());
        }
        public DataTable GetImg(int id)
        {
            SqlParameter[] paras = { new SqlParameter("@id", id) };
            return sqlHelper.GetTab("select * from imgs where id = @id", CommandType.Text, paras);
        }
        public DataTable GetKindImg(int typeid)
        {
            SqlParameter[] paras = { new SqlParameter("@typeId", typeid) };
            return sqlHelper.GetTab("select * from imgs where typeId = @typeId", CommandType.Text, paras);
        }

        public bool DelImg(int id)
        {
            SqlParameter[] paras = { new SqlParameter("@id", id) };
            return sqlHelper.ExeCmd("delete from imgs where id = @id", CommandType.Text, paras);
        }
        public DataTable GetTopImgs()
        {
            return sqlHelper.GetTab("select top 5 * from imgs", CommandType.Text);
        }
    }
}
