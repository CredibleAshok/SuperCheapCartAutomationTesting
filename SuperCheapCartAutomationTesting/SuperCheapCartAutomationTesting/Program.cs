using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SuperCheapCartAutomationTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFirstTest();
            Console.WriteLine("Congrats");
        }

        //todo: remove this static keyword and create a proper architecture for test cases.
        public static void MyFirstTest()
        {
            var driver = new ChromeDriver(@"C:\Dev\Projects\SuperCheapCartAutomationTesting\SuperCheapCartAutomationTesting\dependencies");
            driver.Navigate().GoToUrl("https://www.google.com.au/");
            var v = driver.FindElement(By.Name("q"));
            v.SendKeys("tsa");
            v.Submit();
            Assert.assertEquals(null, driver.FindElement(By.LinkText("TSA - YouTube")));
            
        }
    }
}
