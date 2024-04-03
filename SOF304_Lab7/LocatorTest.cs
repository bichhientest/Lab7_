using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOF304_Lab7
{
	public class LocatorTest
	{
		private IWebDriver driver;
		private string url = @"file:///C:/Users/LENOVO/Documents/Zalo%20Received%20Files/checkout.html";
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
			IWebElement fullnameElement=driver.FindElement(By.XPath("//*[@id=\"fname\"]"));
            fullnameElement.SendKeys("Bich Hien");
            IWebElement EmailElement = driver.FindElement(By.XPath("//*[@id=\"email\"]"));
            EmailElement.SendKeys("hienltbpd09299@");
            IWebElement AddressElement = driver.FindElement(By.XPath("//*[@id=\"adr\"]"));
            AddressElement.SendKeys("102 PCT");
            IWebElement cityElement = driver.FindElement(By.XPath("//*[@id=\"city\"]"));
            cityElement.SendKeys("Da Nang");
            IWebElement stateElement = driver.FindElement(By.XPath("//*[@id=\"state\"]"));
            stateElement.SendKeys("NY");
            IWebElement zipElement = driver.FindElement(By.XPath("//*[@id=\"zip\"]"));
            zipElement.SendKeys("1001");

            IWebElement namecardElement = driver.FindElement(By.XPath("//*[@id=\"cname\"]"));
            namecardElement.SendKeys("Bichhien");
            IWebElement numbercardElement = driver.FindElement(By.XPath("//*[@id=\"ccnum\"]"));
            numbercardElement.SendKeys("111-2222-333");
            IWebElement expmonthElement = driver.FindElement(By.XPath("//*[@id=\"expmonth\"]"));
            expmonthElement.SendKeys("10");
            IWebElement expyearElement = driver.FindElement(By.XPath("//*[@id=\"expyear\"]"));
            expyearElement.SendKeys("2024");
            IWebElement cvvElement = driver.FindElement(By.XPath("//*[@id=\"cvv\"]"));
            cvvElement.SendKeys("255");
       
        }
		[TearDown]
		public void TearDown()
		{
			Thread.Sleep(4000);
			driver.Quit();

		}

	}
}
