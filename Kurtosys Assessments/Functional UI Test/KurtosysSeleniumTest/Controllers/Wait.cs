using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KurtosysSeleniumTest.Controllers
{
    public class Wait
    {
        public static void WaitOne()
        {
            Thread.Sleep(1000);
        }

        public static void WaitTwo()
        {
            Thread.Sleep(2000);
        }

        public static void WaitThree()
        {
            Thread.Sleep(3000);
        }
    }
}
