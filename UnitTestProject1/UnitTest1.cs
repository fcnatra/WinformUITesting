using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Integration")]
        public void ClickingOnButtonConvertToUpperUpperizesTheTextInTheTextBox()
        {
            var expectedResult = "ABC123!\"·";

            var settings = new Dictionary<string, object>();
            settings.Add("platformName", OpenQA.Selenium.PlatformType.Windows);
            settings.Add("deviceName", "WindowsPC");

            var appCapabilities = new DesiredCapabilities(settings);
            var filePath = @"%UserProfile%\Documents\Proof of Concepts\JustAWinForm\JustAWinForm\bin\Debug\JustAWinForm.exe";
            appCapabilities.SetCapability("app", filePath);

            var localHostUri = new Uri("http://127.0.0.1:4723/wd/hub");
            var applicationSession = new WindowsDriver<WindowsElement>(localHostUri, appCapabilities);

            WindowsElement textBox = applicationSession.FindElementByAccessibilityId("txtTextToConvert");
            textBox.SendKeys(expectedResult.ToLower());

            WindowsElement btnUpperize = applicationSession.FindElementByAccessibilityId("btnConvertToUpper");
            btnUpperize.Click();

            var result = textBox.Text;

            applicationSession.CloseApp();

            Assert.AreEqual(expectedResult, result);
        }
    }
}
