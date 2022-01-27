﻿<%@ Application Language="C#" %>
<%@ Import Namespace="wevfirn2" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        RouteConfig.RegisterRoutes(RouteTable.Routes);
        BundleConfig.RegisterBundles(BundleTable.Bundles);
        Application.Add("Key", "12345");
        string Key = (string)Application["Key"];

        HWSettings Settings = HwManager.LoadSettings(Server.MapPath("~/App_Data/Settings.xml"));
        Application.Add("Settings", Settings);
    }

    void Session_Start(object sender, EventArgs e)
    {
        if (Application["Counter"]==null)
        { Application .Add("Counter ", 0);
        }
        int iCounter = Convert.ToInt32(Application["Counter"]);
        iCounter++;
        
        Application["Counter"] = iCounter.ToString();

    }

</script>
