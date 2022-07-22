using KurtosysSeleniumTest.Controllers;
using KurtosysSeleniumTest.PageFactory;
using NUnit.Framework;
using System;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium;

namespace KurtosysSeleniumTest.KurtosysTests
{
    [TestFixture]
    public class KurtosysSampleTests
    {
        public static string FirstName = "John";
        public static string LastName = "John";
        public static string Company = "BVC";


        [Test(Description = ""), Category("Kurtosys")]
        [Order(1)]
        public void KurtosysSampleTest()
        {
            {
                try
                {
                    LaunchBrowser.startBrowser();
                    KurtosysElements kurt = new KurtosysElements();
                    SetElement.Click(kurt.ResourcesMenu);
                    Wait.WaitThree();
                    SetElement.PageScrollDown();
                    SetElement.Click(kurt.WhitePapersAndEBooks);
                    Wait.WaitThree();
                    Assert.IsTrue(SetElement.GetText(kurt.WhitePapersText) == "White Papers");
                    SetElement.Click(kurt.DigitalRevolution);
                    Wait.WaitThree();
                    SetElement.EnterText(kurt.FirstName, FirstName);
                    SetElement.PageScrollDown();
                    SetElement.EnterText(kurt.LastName, LastName);
                    Wait.WaitOne();
                    SetElement.EnterText(kurt.Company, Company);
                    Wait.WaitOne();
                    SetElement.Click(kurt.Industry);
                    Wait.WaitOne();
                    SetElement.Click(kurt.ContinueToNewsLetter);
                    Screenshot ss = ((ITakesScreenshot)Properties.driverIe).GetScreenshot();
                    //ss.SaveAsFile("C://FormError.png", System.Drawing.Imaging.ImageFormat.Png);
                    Console.Read();
                    Assert.IsTrue(SetElement.GetText(kurt.ErrorText) == "This field is required.");
                    Wait.WaitTwo();
                }
                catch (Exception Log) { Logging.Error(Log);Assert.Fail(); }
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            Wait.WaitOne();
            KillProcess.ProcessKill(Properties.driverIe);
        }
    }
}

