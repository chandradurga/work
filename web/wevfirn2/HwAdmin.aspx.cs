using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Account_HwAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // Response.Redirect("Hwlogin.aspx");
    }
    //HWSettings Settings = (HWSettings)Application["Settings"];
    
    //TextBoxDefaultPageTex.Text = Settings.DefaultPageText1;


    protected void ButtonSave_Click(object sender, EventArgs e)
    {
        HWSettings Settings = (HWSettings)Application["Settings"];

        Settings.DefaultPageText1=TextBoxDefaultPageTex.Text;
        Settings.DefaultPageText2 = TextBoxDefaultPageTex2.Text;
         
         Settings.DefaultPageText3 = TextBox1hea.Text;
        Settings.DefaultPageText4 = TextBox1foot.Text;

        HwManager.SaveSettings(Server.MapPath("~/App_Data/Settings.xml"), Settings);
        Application["Settings"] = Settings;

    }

    protected void TextBoxDefaultPageTex2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBoxDefaultPageTex_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1hea_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1foot_TextChanged(object sender, EventArgs e)
    {

    }
}