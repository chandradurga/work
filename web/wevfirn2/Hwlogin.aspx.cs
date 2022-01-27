using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 
using System.Web.Configuration;



public partial class Account_Hwlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

   

    protected void Button1_Click(object sender, EventArgs e)
    {
        string UserName = WebConfigurationManager.AppSettings["PFUserName"];
        string PassWord = WebConfigurationManager.AppSettings["PFPassWord"];
        if (TextBoxEmail.Text == UserName && TextBoxPassword.Text == PassWord)
        {
            Session.Add("UserId", UserName);
            Session["UserId"] = UserName;
            Response.Redirect("HwAdmin.aspx");
        }
        else
        {

            LabelMessage.Text = "Please enter the correct Username and Password";
        }
    }
}