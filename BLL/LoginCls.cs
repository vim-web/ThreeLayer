using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace BLL
{
   public class LoginCls
    {
        ConnectionCls obj = new ConnectionCls();
        public string GetCountId(string Una, string pwd)
        {

            string str = "select count(id)from reg where Username='" + Una + "' and password='" + pwd + "'";
            string cid = obj.exe_scalar(str);
            return cid;
        }
        public string GETID(string Una, string pwd)
        {
            string s = "select id from reg where Username='" + Una + "' and password='" + pwd + "'";
            string id = obj.exe_scalar(s);
            return id;
        }
    }
}
