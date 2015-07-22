using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace dal
{
    public class articlesService
    {
        SQLHelper sqlHelper = new SQLHelper();
        public int AddArticle(string title, string mainContent, int typeId)
        {
            SqlParameter[] paras = {
                                     new SqlParameter("@title", title),
                                     new SqlParameter("@mainContent", mainContent),
                                     new SqlParameter("@typeId", typeId)
                                   };
            return int.Parse(sqlHelper.ExeScl("insert into articles(title,mainContent,typeId) values(@title,@mainContent,@typeId)", CommandType.Text, paras).ToString());
        }
        public DataTable GetArticles(int typeid)
        {
            SqlParameter[] paras = { new SqlParameter("@typeId", typeid) };
            return sqlHelper.GetTab("select articles.*,articleType.articleType from articles inner join articleType on articleType.id = articles.typeId where typeId = @typeId", CommandType.Text, paras);
        }
        public DataTable GetAllArticles()
        {
            return sqlHelper.GetTab("select articles.*,articleType.articleType from articles inner join articleType on articleType.id = articles.typeId order by articles.createTime desc", CommandType.Text);
        }

        public DataTable GetArticle(int id)
        {
            SqlParameter[] paras = { new SqlParameter("@id", id) };
            return sqlHelper.GetTab("select articles.*,articleType.articleType from articles inner join articleType on articleType.id = articles.typeId where articles.id = @id", CommandType.Text, paras);
        }
        public bool UpdateArticle(int id, string title, string mainContent, int typeId)
        {
            SqlParameter[] paras = {
                                       new SqlParameter("@id",id),
                                       new SqlParameter("@title",title),
                                       new SqlParameter("@mainContent",mainContent),
                                       new SqlParameter("@typeId",typeId)
                                   };
            return sqlHelper.ExeCmd("update articles set title = @title,mainContent = @mainContent,typeId = @typeId where id = @id", CommandType.Text, paras);
        }
        public bool DeleteArticle(int id)
        {
            SqlParameter[] paras = { new SqlParameter("@id", id) };
            return sqlHelper.ExeCmd("delete from articles where id = @id", CommandType.Text, paras);
        }
        public DataTable GetTopTenAtc()
        {
            return sqlHelper.GetTab("select top 15 * from articles order by createTime desc", CommandType.Text);
        }
        public bool AddRemark(int atcId, string userIP, string remark)
        {
            SqlParameter[] paras = {
                                        new SqlParameter("@atcId",atcId),
                                        new SqlParameter("@userIP",userIP),
                                        new SqlParameter("@remark",remark)
                                    };
            return sqlHelper.ExeCmd("insert into remarks(atcId,userIP,remark,remarkType) values(@atcId,@userIP,@remark,'文章评论')", CommandType.Text, paras);
        }
        public DataTable GetRemarks(int atcId)
        {
            SqlParameter[] paras = { new SqlParameter("@atcId", atcId) };
            return sqlHelper.GetTab("select * from remarks where atcId = @atcId and remarkType = '文章评论'", CommandType.Text, paras);
        }
        public DataTable SearchArticle(string Keywords)
        {
            return sqlHelper.GetTab("select articles.*,articleType.articleType from articles inner join articleType on articleType.id = articles.typeId where title like '%" + Keywords + "%' or mainContent like '%" + Keywords + "%'", CommandType.Text);
        }
        public int GetAtcRmks(int id)
        {
            SqlParameter[] paras = { new SqlParameter("@id", id) };
            return int.Parse(sqlHelper.ExeScl("select count(*) from remarks where atcId = @id and remarkType = '文章评论'", CommandType.Text, paras).ToString());
        }
        public bool AddViewCount(int id)
        {
            SqlParameter[] paras = { new SqlParameter("@id", id) };
            return sqlHelper.ExeCmd("update articles set viewTimes = viewTimes + 1 where id = @id", CommandType.Text, paras);
        }
    }
}
