using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WebDriverFramework.WebPage;

namespace FleetMatics.PageObjects
{
    public class MainPage
    {
        IWebDriver _driver;

        public MainPage(IWebDriver Driver)
        {
            _driver = Driver;
            PageFactory.InitElements(Driver,this);
        }

        [FindsBy(How = How.CssSelector, Using = ".login")]
        protected IWebElement BtnSignIn = null;

/*
        public MainPage Navigate()
        {
            _driver.Navigate().GoToUrl("http://automationpractice.com");
            return this;
        }
 * */

        public SignIn clickSignInButton()
        {
            BtnSignIn.Click();
            return new SignIn(_driver);
        }
       

    }
}
