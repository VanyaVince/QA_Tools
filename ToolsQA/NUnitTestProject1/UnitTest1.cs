using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject1
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://www.sass.com";

        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}