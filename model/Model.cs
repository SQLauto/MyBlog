using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    public class Remark
    {
        int id;
        int atcId;
        string userIP;
        string remarkText;
        DateTime createTime;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int AtcId
        {
            get { return atcId; }
            set { atcId = value; }
        }
        public string UserIP
        {
            get { return userIP; }
            set { userIP = value; }
        }
        public string RemarkText
        {
            get { return remarkText; }
            set { remarkText = value; }
        }
        public DateTime CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
    }
    public class UploadFile
    {
        int id;
        string fileName;
        int typeId;
        string filePath;
        int downCount;
        DateTime createTime;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        public int TypeId
        {
            get { return typeId; }
            set { typeId = value; }
        }
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        public int DownCount
        {
            get { return downCount; }
            set { downCount = value; }
        }
        public DateTime CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
    }
    public class Image
    {
        int id;
        int typeId;
        string imgName;
        string imgPath;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int TypeId
        {
            get { return typeId; }
            set { typeId = value; }
        }
        public string ImgName
        {
            get { return imgName; }
            set { imgName = value; }
        }
        public string ImgPath
        {
            get { return imgPath; }
            set { imgPath = value; }
        }
    }

    public class Article
    {
        int id; // 文章编号
        string title; // 文章标题
        string mainContent; // 文章内容
        int typeId; // 类别编号
        DateTime createTime; // 发表时间
        int viewTimes; // 浏览次数

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string MainContent
        {
            get { return mainContent; }
            set { mainContent = value; }
        }

        public int TypeId
        {
            get { return typeId; }
            set { typeId = value; }
        }

        public DateTime CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

        public int ViewTimes
        {
            get { return viewTimes; }
            set { viewTimes = value; }
        }
    }
}
