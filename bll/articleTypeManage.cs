using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using dal;

namespace bll
{
    // 上层负责检测数据有效性，如字符长度
    public class articleTypeManage
    {
        articleTypeService articleTypeSvc = new articleTypeService();

        /// <summary>
        /// 添加一种文章类型
        /// </summary>
        /// <param name="typeName">新增类型名称</param>
        /// <returns>添加成功则返回true</returns>
        public bool AddArticleType(string typeName)
        {
            return articleTypeSvc.AddArticleType(typeName);
        }

        /// <summary>
        /// 删除一个文章类型
        /// </summary>
        /// <param name="id">要删除的类型编号（主键）</param>
        /// <returns>删除成功则返回true</returns>
        public bool DelArticleType(int id)
        {
            return articleTypeSvc.DelArticleType(id);
        }

        public DataTable GetAllArticleType()
        {
            return articleTypeSvc.GetAllArticleType();
        }

        public bool UpdateArticleType(int id, string articleType)
        {
            return articleTypeSvc.UpdateArticleType(id, articleType);
        }
    }
}
