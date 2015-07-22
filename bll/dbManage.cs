using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using dal;

namespace bll
{
    public class dbManage
    {
        dbService DbSvc = new dbService();

        public bool BackupDb(string bkpath)
        {   // 完整备份
            return DbSvc.BackupDb(bkpath);
        }
        public bool BackupDifrtDb(string bkpath)
        {   // 差异备份
            return DbSvc.BackupDifrtDb(bkpath);
        }
        public bool ResumeDb(string bkpath)
        {
            return DbSvc.ResumeDb(bkpath);
        }
        public DataTable GetAllbaks()
        {
            return DbSvc.GetAllbaks();
        }
        public bool DelBak(int id)
        {
            return DbSvc.DelBak(id);
        }
    }
}
