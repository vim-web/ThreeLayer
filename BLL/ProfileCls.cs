using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
   public class ProfileCls
    {
        ConnectionCls obj = new ConnectionCls();
        public SqlDataReader fun_getData(int id)
        {
            string strsel = "select name,age,address,Photo from reg where id=" + id + "";
            SqlDataReader dr = obj.fun_exereader(strsel);
            return dr;
        }
    }
}
