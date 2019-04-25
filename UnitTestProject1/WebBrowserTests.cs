using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;

namespace UnitTestProject1
{
    [TestClass]
    public class WebBrowserTests
    {
        private IWebDriver sessionDriver;

        [TestInitialize]
        public void TestSetup()
        {
            var appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability(CapabilityType.BrowserName, "Chrome");
            appCapabilities.SetCapability(CapabilityType.PlatformName, "Windows");
            appCapabilities.SetCapability("deviceName", "WindowsPC");
           
            var filePath = @"C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe";
            appCapabilities.SetCapability("app", filePath);

            var localHostUri = new Uri("http://127.0.0.1:4723/wd/hub");
            var timeOut = new TimeSpan(0, 0, 5);
            sessionDriver = new WindowsDriver<IWebElement>(localHostUri, appCapabilities, timeOut);
            sessionDriver.Manage().Timeouts().ImplicitWait = timeOut;
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            sessionDriver.Close();
        }

        [TestMethod]
        [TestCategory("Integration")]
        public void GoogleSearchHomePageHasGoogleAsTitle()
        {
            var expectedResult = "Google";

            sessionDriver.Url = "https://www.google.com";
            sessionDriver.Navigate();

            System.Threading.Thread.Sleep(2000);
            var result = sessionDriver.Title;

            Assert.AreEqual(expectedResult, result);
        }
    }
}
