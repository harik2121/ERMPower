using System.Configuration;

namespace ERMPower.common.POM
{
    public class URLs
    {

        static string WebServerAU { get { return ConfigurationManager.AppSettings["WebServerAU"]; } }
       

        public static string GoToUrlAU()
        {
            var currentUrl = WebServerAU;
            return currentUrl;
        }

      


    }
}
