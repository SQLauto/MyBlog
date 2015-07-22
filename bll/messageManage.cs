using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using dal;

namespace bll
{
    public class messageManage
    {
        messageService MsgSvc = new messageService();
        public DataTable GetAllMsgs()
        {
            return MsgSvc.GetAllMsgs();
        }
        public bool AddMsg(string userIP, string remark)
        {
            return MsgSvc.AddMsg(userIP, remark);
        }
        public DataTable GetTopFiveMsgs()
        {
            return MsgSvc.GetTopFiveMsgs();
        }
        public bool DelMsg(int id)
        {
            return MsgSvc.DelMsg(id);
        }
    }
}
