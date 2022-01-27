using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for HwManager
/// </summary>
/// 
public class HWSettings
{
    public String DefaultPageText1 { get; set; }
    public String DefaultPageText2 { get; set; }
    public String DefaultPageText3 { get; set; }
    public String DefaultPageText4 { get; set; }

} 
public class HwManager
{
   
    public HwManager()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static HWSettings LoadSettings(string FilePath)
    {
        HWSettings Settings = new HWSettings();
        try
        {
           
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(HWSettings));
            System.IO.StreamReader file = new System.IO.StreamReader(FilePath);
            Settings = (HWSettings)reader.Deserialize(file);
            file.Close();
            return Settings;

        }
        catch(Exception)
        {
            return Settings;
        }

    }
    public static void SaveSettings(string FilePath, HWSettings SettingsObj)

    {
         System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(HWSettings));
         var FileName = ("HwSettings.xml");
         System.IO.FileStream file = System.IO.File.Create(FilePath );
         writer.Serialize(file, SettingsObj);
         file.Close();
    }
}