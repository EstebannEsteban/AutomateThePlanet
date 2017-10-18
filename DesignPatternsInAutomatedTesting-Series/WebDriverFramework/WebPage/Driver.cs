using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace WebDriverFramework.WebPage
{
    public static class Driver
    {

        public static IWebDriver WebDriver;

        public static IWebDriver StartBrowser(){
            WebDriver = new FirefoxDriver();
            return WebDriver;
        }

    }
}
