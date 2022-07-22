using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurtosysSeleniumTest
{   
        enum PropType
        {
            Id,
            ClassName,
            Name,
            XPath,
            CssSelector
        }
        public class Properties
        {

            public static IWebDriver driverIe { get; set; }
        }
}
