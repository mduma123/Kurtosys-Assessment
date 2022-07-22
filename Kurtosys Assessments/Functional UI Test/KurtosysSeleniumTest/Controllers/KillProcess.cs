using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KurtosysSeleniumTest.Controllers
{
    public class KillProcess
    {
        public static void BrowserQuit(IWebDriver driverIe)
        {
            Properties.driverIe.Quit();
            Wait.WaitOne();
            Process[] chromeProcesses = Process.GetProcessesByName("chrome.exe");

            foreach (var chrome in chromeProcesses)
            {
                chrome.Kill();
            }

            Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver.exe");

            foreach (var chromeD in chromeDriverProcesses)
            {
                chromeD.Kill();
            }


            Process[] firefoxProcesses = Process.GetProcessesByName("firefox.exe");

            foreach (var firefox in firefoxProcesses)
            {
                firefox.Kill();
            }

        }
        public static void ProcessKill(IWebDriver driverIe)
        {
            try
            {

                driverIe.Quit();
                driverIe = null;
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.TraceError(e.StackTrace);
                Assert.Fail(e.Message + " " + e.StackTrace);
            }
        }
    }
}

