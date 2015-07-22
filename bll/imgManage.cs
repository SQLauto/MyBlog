using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using dal;
using model;

namespace bll
{
    public class imgManage
    {
        imgService ImgSvc = new imgService();
        public int GetImgCounts()
        {   // 获取图片总数
            return ImgSvc.GetImgCounts();
        }
        public int AddImg(Image img)
        {   // 上传图片
            return ImgSvc.AddImg(img.TypeId, img.ImgName, img.ImgPath);
        }
        public DataTable GetImg(int id)
        {   // 获取一个图片
            return ImgSvc.GetImg(id);
        }
        public DataTable GetKindImg(int typeid)
        {   // 获取指定类型的所有图片
            return ImgSvc.GetKindImg(typeid);
        }
        public bool DelImg(int id)
        {   // 删除图片
            return ImgSvc.DelImg(id);
        }
        public DataTable GetTopImgs()
        {
            return ImgSvc.GetTopImgs();
        }
    }
}
