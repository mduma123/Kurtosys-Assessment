using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurtosysSeleniumTest.Controllers
{
    public class SetElement
    {
        /*** Dynamic wait method until element found with text  ****/
        public static void WaitUntilElementDisplayed(string text)
        {
            for (int i = 0; i < 30; i++)
            {
                try
                {
                    var eleText = Properties.driverIe.FindElement(By.XPath(text)).Text;
                    if (eleText != "")
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Assert.Fail(e.Message);
                }
            }
        }
        /*** Page scroll to the end  ****/
        public static void PageScrollDown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Properties.driverIe;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }
        /*** Click on element ****/
        public static void Click(String element)
        {
            new WebDriverWait(Properties.driverIe, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementIsVisible(By.XPath(element))).Click();
            
        }
        /*** Enter text in to text box ****/
        public static void EnterText(String element, string text)
        {
            new WebDriverWait(Properties.driverIe, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementIsVisible(By.XPath(element))).Clear();
            new WebDriverWait(Properties.driverIe, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementIsVisible(By.XPath(element))).SendKeys(text);
        }
       
        /*** Get text of an element ****/
        public static string GetText(String element)
        {
            WaitUntilElementDisplayed(element);
            return new WebDriverWait(Properties.driverIe, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementIsVisible(By.XPath(element))).Text;
        }


        /*** Verify Element is Displayed  ****/
        public static bool ElementIsDisplayed(String element)
        {
            return new WebDriverWait(Properties.driverIe, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementIsVisible(By.XPath(element))).Displayed;

        }
        /*** Verify Element is Enabled  ****/
        public static bool ElementIsEnabled(String element)
        {
            return new WebDriverWait(Properties.driverIe, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementIsVisible(By.XPath(element))).Enabled;

        }

        /*** Verify element disapear  ****/
        public static void ElementDisappear(String element)
        {
            new WebDriverWait(Properties.driverIe, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(element)));
        }

        /*** Verify element disapear  ****/
        public static bool ElementIsInvisible(String element)
        {
            return new WebDriverWait(Properties.driverIe, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(element)));
        }

        /*** Accept True Alert  ****/
        public static bool AcceptAlertTrue()
        {
            bool flag = false;
            IAlert alert = Properties.driverIe.SwitchTo().Alert();
            flag = true;
            return flag;
        }

    }
}
