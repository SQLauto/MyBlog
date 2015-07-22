using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using dal;
using model;

namespace bll
{
    public class filesManage
    {
        filesService FileSvc = new filesService();

        public bool AddFile(UploadFile upFile)
        {
            return FileSvc.AddFile(upFile.FileName, upFile.TypeId, upFile.FilePath);
        }
        public DataTable GetAllFiles()
        {
            return FileSvc.GetAllFiles();
        }
        public bool DelFile(int id)
        {
            return FileSvc.DelFile(id);
        }
        public DataTable GetKindFiles(int typeId)
        {
            return FileSvc.GetKindFiles(typeId);
        }
        public DataTable GetTopFiles()
        {
            return FileSvc.GetTopFiles();
        }
        public DataTable GetFileRemark(int id)
        {
            return FileSvc.GetFileRemark(id);
        }
        public DataTable GetFile(int id)
        {
            return FileSvc.GetFile(id);
        }
        public bool AddFileRemark(Remark rmk)
        {
            return FileSvc.AddFileRemark(rmk.AtcId, rmk.UserIP, rmk.RemarkText);
        }
        public bool AddDownCount(int id)
        {   // 自增下载次数
            return FileSvc.AddDownCount(id);
        }
    }
}
