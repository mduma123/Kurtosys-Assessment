using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurtosysSeleniumTest.PageFactory
{
    public class KurtosysElements
    {

        /*****Kurtosysis Page Elements****/
        public string ResourcesMenu = "(//div[@class='kurtosys-menu-title']//span)[3]";
        public string WhitePapersAndEBooks = "//div[@class='elementor-element elementor-element-1e16b85 elementor-widget elementor-widget-heading']//h4//a";
        public string WhitePapersText = "//div[@class='elementor-widget-container']//h2";
        public string DigitalRevolution = "(//p[@class='elementor-post__title']//a)[1]";
        public string FirstName = "//label[text()='First Name']";
        public string LastName = "//label[text()='Last Name']";
        public string Company = "//label[text()='Company']";
        public string Industry = "//label[text()='Industry']";
        public string ContinueToNewsLetter = "//input[@value='Continue to White Paper']";
        public string ErrorText = "//p[text()='This field is required.']";
     


        /****Loading Page elements****/
        public string Pageloading = "//div[@id='loading']";


    }
}

