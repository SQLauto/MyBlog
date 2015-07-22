using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace dal
{
    public class articleTypeService
    {
        SQLHelper sqlHelper = new SQLHelper();

        /// <summary>
        /// 添加一种文章类型
        /// </summary>
        /// <param name="typeName">新增类型名称</param>
        /// <returns>添加成功则返回true</returns>
        public bool AddArticleType(string typeName)
        {
            SqlParameter[] paras = { new SqlParameter("@typeName", typeName) };
            return sqlHelper.ExeCmd("insert into articleType(articleType) values(@typeName)", CommandType.Text, paras);
        }

        /// <summary>
        /// 删除一个文章类型
        /// </summary>
        /// <param name="id">要删除的类型编号（主键）</param>
        /// <returns>删除成功则返回true</returns>
        public bool DelArticleType(int id)
        {
            SqlParameter[] paras = { new SqlParameter("@id", id) };
            return sqlHelper.ExeCmd("delete from articleType where id = @id", CommandType.Text, paras);
        }
        public bool UpdateArticleType(int id, string articleType)
        {
            SqlParameter[] paras = {
                                       new SqlParameter("@id", id),
                                       new SqlParameter("@articleType", articleType)
                                   };
            return sqlHelper.ExeCmd("update articleType set articleType = @articleType where id = @id", CommandType.Text, paras);
        }

        public DataTable GetAllArticleType()
        {
            return sqlHelper.GetTab("select * from articleType", CommandType.Text);
        }
    }
}
