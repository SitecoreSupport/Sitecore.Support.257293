namespace Sitecore.Support.Client.LicenseOptions.Controllers
{ 
    using Sitecore;
    using Sitecore.Security.Accounts;
    using Sitecore.SecurityModel.License;
    using Sitecore.Text;
    using Sitecore.Web;
    using System.Web.Mvc;

    public class BoostUsersHttpsController : Controller
    {
        [HttpGet]
        public void RedirectToBoost()
        {
            if (!Context.User.IsAuthenticated)
            {
                base.Response.StatusCode = 401;
            }
            else
            {
                base.Response.Redirect(GetBoostUrl(), true);
            }
        }

        protected string GetBoostUrl()
        {
            UrlString urlString = new UrlString(WebUtil.GetFullUrl(new StartUrlManager().GetStartUrl(Context.User)));
            urlString.Add("inv", "1");

            #region Modified Code Region

            /*
            Original Code:            
            UrlString urlString2 = new UrlString("http://www.sitecore.net/boost"); */
            UrlString urlString2 = new UrlString("https://www.sitecore.net/boost");

            #endregion

            urlString2.Add("url", urlString.ToString());
            urlString2.Add("lid", StringUtil.GetString(License.LicenseID));
            urlString2.Add("host", StringUtil.GetString(WebUtil.GetHostName()));
            urlString2.Add("ip", StringUtil.GetString(WebUtil.GetHostIPAddress()));
            urlString2.Add("licensee", StringUtil.GetString(License.Licensee));
            urlString2.Add("iisname", StringUtil.GetString(WebUtil.GetIISName()));
            return urlString2.ToString();
        }
    }
}