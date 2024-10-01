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
    public partial class Log : System.Web.UI.Page
    {
        LoginCls obj = new LoginCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = obj.GetCountId(TextBox1.Text, TextBox2.Text);
            if (s != "0")
            {
                string id = obj.GETID(TextBox1.Text, TextBox2.Text);
                Session["uid"] = id;
                Response.Redirect("User_Profile.aspx");
            }
            else
            {
                Label1.Text = "invalid";
            }
        }
    }
}