using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Services;

/// <summary>
/// Summary description for HomeController
/// </summary>
public partial class _Default : System.Web.UI.Page
{
    

    protected static string ReCaptcha_Key = "6LfXxh4UAAAAAGEh40qEriILVIXSeAsMAGoHtfIG";
    protected static string ReCaptcha_Secret = "6LfXxh4UAAAAAHTnx54D6toOM_AM5mDHXekibx4H";

    [WebMethod]

    public static string VerifyCaptcha(string response)
    {
        string url = "https://www.google.com/recaptcha/api/siteverify?secret=" + ReCaptcha_Secret + "&response=" + response;
        return (new WebClient()).DownloadString(url);
        
    }
}