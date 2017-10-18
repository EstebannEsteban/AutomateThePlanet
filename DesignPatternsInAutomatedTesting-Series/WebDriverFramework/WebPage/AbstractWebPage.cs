using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Firefox;


namespace WebDriverFramework.WebPage
{
    public abstract class AbstractWebPage
    {
        private IWebDriver _driver;

        public AbstractWebPage(IWebDriver Driver)
        {
            _driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        protected T NewPage<T>() where T : AbstractWebPage
        {
            return (T)Activator.CreateInstance(typeof(T), _driver);
        }
       
    }
}
