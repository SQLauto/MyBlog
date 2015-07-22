using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using dal;

namespace bll
{
    public class fileTypeManage
    {
        fileTypeService FileTypeSvc = new fileTypeService();
        public bool AddFileType(string typeName)
        {   // 添加文件类型
            return FileTypeSvc.AddFileType(typeName);
        }
        public bool DelFileType(int id)
        {   // 删除指定编号的文件类型
            return FileTypeSvc.DelFileType(id);
        }
        public DataTable GetFileTypes()
        {   // 获取所有文件类型
            return FileTypeSvc.GetFileTypes();
        }
        public bool UpdateFileType(int id, string fileType)
        {   // 更新文件类型
            return FileTypeSvc.UpdateFileType(id, fileType);
        }
    }
}
