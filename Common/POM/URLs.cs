using System.Configuration;

namespace ERMPower.common.POM
{
    public class URLs
    {

        static string WebServer { get { return ConfigurationManager.AppSettings["WebServer"]; } }
       

        public static string GoToUrl()
        {
            var currentUrl = WebServer;
            return currentUrl;
        }
    }
}
