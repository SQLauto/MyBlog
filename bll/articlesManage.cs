using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using model;
using dal;

namespace bll
{
    public class articlesManage
    {
        articlesService AtcSvc = new articlesService();
        public int AddArticle(Article atc)
        {   // 发表文章
            return AtcSvc.AddArticle(atc.Title, atc.MainContent, atc.TypeId);
        }
        public DataTable GetArticles(int typeid)
        {   // 获取某类别下的所有文章
            return AtcSvc.GetArticles(typeid);
        }
        public DataTable GetAllArticles()
        {   // 获取所有文章
            return AtcSvc.GetAllArticles();
        }
        public bool UpdateArticle(Article atc)
        {   // 更新文章
            return AtcSvc.UpdateArticle(atc.Id, atc.Title, atc.MainContent, atc.TypeId);
        }
        public bool DeleteArticle(int id)
        {   // 删除文章
            return AtcSvc.DeleteArticle(id);
        }
        public DataTable GetArticle(int id)
        {   // 读取一篇文章
            return AtcSvc.GetArticle(id);
        }
        public DataTable GetTopTenAtc()
        {   // 获取最新10
            return AtcSvc.GetTopTenAtc();
        }
        public bool AddRemark(Remark rmk)
        {   // 添加评论
            return AtcSvc.AddRemark(rmk.AtcId, rmk.UserIP, rmk.RemarkText);
        }
        public DataTable GetRemarks(int atcId)
        {   // 获取评论
            return AtcSvc.GetRemarks(atcId);
        }
        public DataTable SearchArticle(string Keywords)
        {   // 文章搜索
            return AtcSvc.SearchArticle(Keywords);
        }
        public bool AddViewCount(int id)
        {   // 增加浏览次数
            return AtcSvc.AddViewCount(id);
        }
        public int GetAtcRmks(int id)
        {   // 获取指定文章评论数
            return AtcSvc.GetAtcRmks(id);
        }
    }
}