using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Data.SqlClient;

namespace ThreeLayer2
{
    public partial class User_Profile : System.Web.UI.Page
    {
        ProfileCls obj = new ProfileCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            int uid = Convert.ToInt32(Session["uid"]);
            SqlDataReader dr = obj.fun_getData(uid);
            while (dr.Read())
            {
                Label1.Text = dr["name"].ToString();
                Label2.Text = dr["age"].ToString();
                Label3.Text = dr["address"].ToString();
                Image1.ImageUrl = dr["Photo"].ToString();
            }

        }
    }
}