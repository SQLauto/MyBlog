using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace dal
{
    public class filesService
    {
        SQLHelper sqlHelper = new SQLHelper();
        // 上传文件
        public bool AddFile(string fileName, int typeId, string filePath)
        {
            SqlParameter[] paras =  {
                                        new SqlParameter("@fileName", fileName),
                                        new SqlParameter("@typeId", typeId),
                                        new SqlParameter("@filePath", filePath)
                                    };
            return sqlHelper.ExeCmd("insert into files(fileName,typeId,filePath) values(@fileName,@typeId,@filePath)", CommandType.Text, paras);
        }
        // 获取所有文件
        public DataTable GetAllFiles()
        {
            return sqlHelper.GetTab("select files.*,fileType.fileType from files inner join fileType on fileType.id = files.typeId order by files.createTime desc", CommandType.Text);
        }

        public DataTable GetKindFiles(int typeId)
        {
            SqlParameter[] paras = { new SqlParameter("@typeid", typeId) };
            return sqlHelper.GetTab("select files.*,fileType.fileType from files inner join fileType on fileType.id = files.typeId where files.typeId = @typeid", CommandType.Text, paras);
        }
        public bool DelFile(int id)
        {
            SqlParameter[] paras = { new SqlParameter("@id", id) };
            return sqlHelper.ExeCmd("delete from files where id = @id", CommandType.Text, paras);
        }
        public DataTable GetTopFiles()
        {
            return sqlHelper.GetTab("select top 6 files.*,fileType.fileType from files inner join fileType on fileType.id = files.typeId order by createTime desc", CommandType.Text);
        }

        public DataTable GetFileRemark(int id)
        {
            SqlParameter[] paras = { new SqlParameter("@id", id) };
            return sqlHelper.GetTab("select * from remarks where atcId = @id and remarkType = '文件评论'", CommandType.Text, paras);
        }
        public DataTable GetFile(int id)
        {
            SqlParameter[] paras = { new SqlParameter("@id", id) };
            return sqlHelper.GetTab("select * from files where id = @id", CommandType.Text, paras);
        }
        public bool AddFileRemark(int fileId, string userIP, string remark)
        {
            SqlParameter[] paras = {
                                        new SqlParameter("@fileId",fileId),
                                        new SqlParameter("@userIP",userIP),
                                        new SqlParameter("@remark",remark)
                                    };
            return sqlHelper.ExeCmd("insert into remarks(atcId,userIP,remark,remarkType) values(@fileId,@userIP,@remark,'文件评论')", CommandType.Text, paras);
        }
        public bool AddDownCount(int id)
        {
            SqlParameter[] paras = { new SqlParameter("@id", id) };
            return sqlHelper.ExeCmd("update files set downCount = downCount + 1 where id = @id", CommandType.Text, paras);
        }
    }
}
