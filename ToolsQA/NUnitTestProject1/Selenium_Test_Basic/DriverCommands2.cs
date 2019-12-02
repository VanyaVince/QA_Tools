using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
namespace NUnitTestProject1.Selenium_Test_Basic
{
    class DriverCommands2
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://demoqa.com/frames-and-windows/";

            driver.FindElement(By.XPath("//*[@id='main']/div/div/form/input")).Click();
            //driver.Close();
        }
    }
}
