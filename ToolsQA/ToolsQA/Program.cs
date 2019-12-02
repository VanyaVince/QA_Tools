using System;
using System.Data;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace ToolsQA
{
    class Program
    {
        static void Main(string[] args)
        {
        }


        //private static 
        private static void WebElementCommands(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://translate.google.com/#view=home&op=translate&sl=es&tl=ru");
            IWebElement element = driver.FindElement(By.XPath("//*[@id='source']"));
            element.SendKeys("Irrespective of his opinion you have your rights and nothing else matters");
            element.Clear();
            //error. checking out!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            ///IWebElement choosingElement = driver.FindElement(By.XPath("//*[@id='sugg - item - es']"));
            //choosingElement.Click();
        }
        private static void NavigationCommands(IWebDriver driver)
        {
            driver.Url = "https://github.com/VanyaVince";
            driver.Navigate().GoToUrl("https://github.com/VanyaVince/LogicalTask");
            driver.Navigate().Back();
            driver.Navigate().Refresh();
        }
    }
}
