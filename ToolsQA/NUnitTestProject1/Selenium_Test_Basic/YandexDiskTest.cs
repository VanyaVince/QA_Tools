using System;
using System.Drawing;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject1.Selenium_Test_Basic
{
    class YandexDiskTest
    {
        [Test]
        public void GetText()
        {
            IWebDriver driver = new ChromeDriver();
            string login = "sviridovich.vanya";
            string password = "tarakan123";

            

            driver.Navigate().GoToUrl("https://disk.yandex.by");

            driver.FindElement(By.XPath("//a[@class='button button_login header__login-link']")).Click();

            driver.FindElement(By.Id("passp-field-login")).SendKeys(login);
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();

            Thread.Sleep(TimeSpan.FromSeconds(1));

            driver.FindElement(By.Id("passp-field-passwd")).SendKeys(password);
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();

            Thread.Sleep(TimeSpan.FromSeconds(1));

            string loginValidation = driver.FindElement(By.XPath("//a[@class='user-account user-account_has-accent-letter_yes user2__current-account']/span")).GetAttribute("innerText");
            Assert.AreEqual(login, loginValidation);

            driver.Quit();

                
            //IWebElement button = driver.FindElement(By.XPath("//button[@class='control button2 button2_view_classic button2_size_l button2_theme_action button2_width_max button2_type_submit passp-form-button']"));

            //driver.FindElement(By.XPath("//a[contains(text(),'NBA.COM')]")).Click(); driver.FindElement(By.TagName("button"))
            //driver.FindElement(By.XPath("//div[@class='am-home ']")).Click();

            //Thread.Sleep(TimeSpan.FromSeconds(1));
            //List<IWebElement> elements = new List<IWebElement>(driver.FindElements(By.ClassName("//div[@class='am-home ']")));
            //Console.WriteLine(elements[5].Text);
        }
    }
}