using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebDriverFramework.WebPage;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using StaticDriver.PageObjects;

namespace StaticDriver.Pages
{
    public class MainPage : AbstractWebPage
    {
        public MainPage(IWebDriver Driver)
            : base(Driver)
        {

        }

        

        [FindsBy(How = How.CssSelector, Using = ".login")]
        protected IWebElement BtnSignIn = null;

        public SignIn clickSignInButton()
        {
            BtnSignIn.Click();
            return NewPage<SignIn>();
        }
    }
}
