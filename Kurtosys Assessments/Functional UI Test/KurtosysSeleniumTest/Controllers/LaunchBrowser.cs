using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurtosysSeleniumTest.Controllers
{
    public class LaunchBrowser
    {
        public static string BROWSER_APP_SETTING = "BrowsersToRun";

        public static void startBrowser()
        {
            AssignBrowser(ConfigurationManager.AppSettings[LaunchBrowser.BROWSER_APP_SETTING]);
            OpenBrowser(ConfigurationManager.AppSettings[LaunchBrowser.BROWSER_APP_SETTING]);
        }

        public static void startBrowser(string BrowsersToRun)
        {
            if (string.IsNullOrEmpty(BrowsersToRun))
            {
                BrowsersToRun = ConfigurationManager.AppSettings[LaunchBrowser.BROWSER_APP_SETTING];
                if (string.IsNullOrEmpty(BrowsersToRun))
                {
                    BrowsersToRun = "Chrome";

                }
            }

            AssignBrowser(BrowsersToRun);
            OpenBrowser(BrowsersToRun);
        }


        public static void OpenBrowser(String BrowserNm)
        {

            Properties.driverIe.Manage().Window.Maximize();
            Properties.driverIe.Navigate().GoToUrl("https://www.kurtosys.com/");
            Properties.driverIe.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5000);
            Properties.driverIe.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);
            

        }
        public static void AssignBrowser(String BrowserNm)
        {
           


            if (BrowserNm.Equals("Firefox"))
            {
                FirefoxOptions firefoxOptions = new FirefoxOptions();
                firefoxOptions.AddArgument("--headless");
                Properties.driverIe = new FirefoxDriver();
            }

            else if (BrowserNm.Equals("Safari"))
            {
                Properties.driverIe = new SafariDriver();
            }

            else
            {
                ChromeOptions chromeOptions = new ChromeOptions();
                // chromeOptions.AddArguments("--headless");
                chromeOptions.AddUserProfilePreference("download.prompt_for_download", false);
                chromeOptions.AddUserProfilePreference("download.directory_upgrade", true);
                chromeOptions.AddUserProfilePreference("safebrowsing.enabled", true);
                Properties.driverIe = new ChromeDriver(chromeOptions);
            }
        }
    }
}
