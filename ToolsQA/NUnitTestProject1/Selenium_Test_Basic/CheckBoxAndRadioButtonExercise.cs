using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject1.Selenium_Test_Basic
{
    public class CheckBoxAndRadioButtonExercise
    {
        private IWebDriver _driver;
        [SetUp]
        public void InitializeDriver()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("http://toolsqa.com/automation-practice-form/");
            _driver.FindElement(By.Id("cookie_action_close_header")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
        [Test]
        public void SelectCheckBoxSexByValue()
        {
            var expectedResult = false;

            List<IWebElement> radioElements = new List<IWebElement>(_driver.FindElements(By.Name("sex")));

            foreach (var radioElement in radioElements)
            {
                var value = radioElement.GetAttribute("value");
                if (value.Equals("Female"))
                    radioElement.Click();
                
                expectedResult = radioElement.Selected;
            }
            Assert.IsTrue(expectedResult);
        }
        [Test]
        public void SelectAutomationToolCheckBoxByCssSelector()
        {
            IWebElement element = _driver.FindElement(By.CssSelector("input[id='tool-1']"));
            element.Click();

            var expectedResult = element.Selected;

            Assert.IsTrue(expectedResult);
        }
        [Test]
        public void SelectExperienceCheckBoxById()
        {
            var element = _driver.FindElement(By.Id("exp-2"));
            element.Click();

            var expectedResult = element.Selected;

            Assert.IsTrue(expectedResult);
        }
        [TearDown]
        public void CLose()
        {
            _driver.Close();
        }
    }
}