using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        HWSettings Settings = (HWSettings)Application["Settings"];
        LabelDefaultPageText1.Text = Settings.DefaultPageText2;
        Label3hea.Text = Settings.DefaultPageText3;
        Label3foo.Text = Settings.DefaultPageText4;

        if ((Boolean)Session["che"] is true)
        {
            Session["che"] = null;

            LabelDefaultPageText1.Text = Settings.DefaultPageText2;

        }
        else
        {
            Response.Write("page is refres");

            LabelDefaultPageText1.Text = Settings.DefaultPageText1;

        }
    }
    protected void Page_preInit(object sender, EventArgs e)
       {
        Session["che"] = Session["che"] is null ? false : true;
      }

    }

    
