using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace BLL
{
    public class InsertCls
    {

        ConnectionCls obj = new ConnectionCls();
        public int DBinsert(string na, int ag, string addr, string ph, string una, string pwd)
        {
            string ins = "insert into reg values('" + na + "'," + ag + ",'" + addr + "','" + ph + "','" + una + "','" + pwd + "')";
            int i = obj.fun_nonquery(ins);
            return i;
        }
    }
}
