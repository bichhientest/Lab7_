using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOF304_Lab7
{
    public class LocatorByTagNameTest
    {
        private IWebDriver driver;
        private string url = @"file:///C:/Users/LENOVO/Documents/Zalo%20Received%20Files/table.html";
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }
        [Test]
        public void Test1()
        {
            var trElements = driver.FindElements(By.TagName("tr"));
            foreach (var item in trElements)
            {
                var tdFirstElement = item.FindElements(By.TagName("td"));
                if (tdFirstElement != null && tdFirstElement.Count > 0)
                    Console.WriteLine($"{tdFirstElement[2].Text}");
            }

        }
        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(3000);
            driver.Quit();

        }

    }
}
