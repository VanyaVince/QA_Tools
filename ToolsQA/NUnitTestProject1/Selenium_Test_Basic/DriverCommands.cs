using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace NUnitTestProject1.Selenium_Test_Basic
{
    class DriverCommands
    {
        [Test]
        public static void Test()
        {
            IWebDriver chrome = new ChromeDriver();
            string url = OpenLink(chrome, "http://shop.demoqa.com");
            string title = chrome.Title;
            string pageSource = chrome.PageSource;
            Console.WriteLine($"\n{title}.\nThe title length is: {GetLength(title)}\n{url}. The url length {GetLength(url)}" +
                $".\nCommon size is {GetLength(title) + GetLength(url)}\n\nThe page source : {pageSource},\nlength is {GetLength(pageSource)}");
            chrome.Quit();
        }

        public static int GetLength(string message)
        {
            return message.Length;
        }
        public static string OpenLink(IWebDriver webDriver, string url)
        {
            return webDriver.Url = url;
        }
    }
}
