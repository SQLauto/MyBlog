using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using dal;

namespace bll
{
    public class adminManage
    {
        adminService AdSvc = new adminService();
        public bool CheckLogin(string userName, string password)
        {
            return AdSvc.CheckLogin(userName, password);
        }
    }
}
