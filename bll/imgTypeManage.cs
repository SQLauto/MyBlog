using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using dal;

namespace bll
{
    public class imgTypeManage
    {
        imgTypeService ImgSvc = new imgTypeService();
        public bool AddImgType(string imgType)
        {
            return ImgSvc.AddImgType(imgType);
        }
        public bool DelImgType(int id)
        {
            return ImgSvc.DelImgType(id);
        }
        public bool UpdateImgType(int id, string imgType)
        {
            return ImgSvc.UpdateImgType(id, imgType);
        }
        public DataTable GetImgType()
        {
            return ImgSvc.GetImgType();
        }
        public int GetTypeKinds()
        {
            return ImgSvc.GetTypeKinds();
        }
    }
}
