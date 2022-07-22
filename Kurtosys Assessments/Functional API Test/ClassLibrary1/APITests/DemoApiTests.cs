using System;
using ClassLibrary1.APIScripts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace APITests
{
    [TestClass]
    public class DemoApiTests
    {
        public string url = "https://www.kurtosys.com/";
        [TestMethod]
        public void StatusCheck()
        {
            var status = new StatusCheck();
            var response = status.StatusCheckk(url);
            Assert.AreEqual(response, 200);

        }

        [TestMethod]
        public void ServerNameCheck()
        {
            var server = new ServerCheck();
            var response = server.SerCheck(url);
            Assert.AreEqual(response, "cloudflare");

        }


    }
}
