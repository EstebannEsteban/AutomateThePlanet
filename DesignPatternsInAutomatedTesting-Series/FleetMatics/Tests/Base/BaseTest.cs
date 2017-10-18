using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using WebDriverFramework.WebPage;
using FleetMatics.PageObjects;

namespace FleetMatics
{
    public class BaseTest
    {
        protected IWebDriver Driver;
        
       
        [SetUp]
        public void SetUp()
        {
            Driver = new FirefoxDriver();
            
        }


        [TearDown]
        public void TearDown()
        {
            Driver.Close();
        }

        public MainPage Navigate(){
            Driver.Navigate().GoToUrl("http://automationpractice.com");
            return new MainPage(Driver);
        }
        


        
    }
}
