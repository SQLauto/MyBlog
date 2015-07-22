using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace dal
{
    public class fileTypeService
    {
        SQLHelper sqlHelper = new SQLHelper();
        public bool AddFileType(string typeName)
        {
            SqlParameter[] paras = { new SqlParameter("@typeName", typeName) };
            return sqlHelper.ExeCmd("insert into fileType(fileType) values(@typeName)", CommandType.Text, paras);
        }
        public bool DelFileType(int id)
        {
            SqlParameter[] paras = { new SqlParameter("@id", id) };
            return sqlHelper.ExeCmd("delete from fileType where id = @id", CommandType.Text, paras);
        }
        public DataTable GetFileTypes()
        {
            return sqlHelper.GetTab("select * from fileType", CommandType.Text);
        }
        public bool UpdateFileType(int id, string fileType)
        {
            SqlParameter[] paras = {
                                       new SqlParameter("@id", id),
                                       new SqlParameter("@fileType", fileType)
                                   };
            return sqlHelper.ExeCmd("update fileType set fileType = @fileType where id = @id", CommandType.Text, paras);
        }
    }
}
