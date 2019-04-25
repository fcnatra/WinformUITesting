using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;

namespace UnitTestProject1
{
    [TestClass]
    public class WinFormTests
    {
        private WindowsDriver<WindowsElement> sessionDriver;

        [TestInitialize]
        public void TestSetup()
        {
            var appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability(CapabilityType.PlatformName, "Windows");
            appCapabilities.SetCapability("deviceName", "WindowsPC");

            var userProfilePath = Environment.GetEnvironmentVariable("UserProfile");
            var filePath = $@"{userProfilePath}\Documents\Proof of Concepts\JustAWinForm\JustAWinForm\bin\Debug\JustAWinForm.exe";
            appCapabilities.SetCapability("app", filePath);

            var localHostUri = new Uri("http://127.0.0.1:4723/wd/hub");
            sessionDriver = new WindowsDriver<WindowsElement>(localHostUri, appCapabilities);
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            sessionDriver.CloseApp();
        }


        [TestMethod]
        [TestCategory("Integration")]
        public void ClickingOnButtonConvertToUpperUpperizesTheTextInTheTextBox()
        {
            var expectedResult = "ABC123!\"·";

            WindowsElement textBox = sessionDriver.FindElementByAccessibilityId("txtTextToConvert");
            textBox.SendKeys(expectedResult.ToLower());
            System.Threading.Thread.Sleep(3000);
            WindowsElement btnUpperize = sessionDriver.FindElementByAccessibilityId("btnConvertToUpper");
            btnUpperize.Click();

            var result = textBox.Text;

            Assert.AreEqual(expectedResult, result);
        }
    }
}
