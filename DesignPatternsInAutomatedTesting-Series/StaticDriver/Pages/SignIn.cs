using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverFramework.WebPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace StaticDriver.PageObjects
{
    public class SignIn:AbstractWebPage
    {
              
        public SignIn(IWebDriver Driver)
            : base(Driver) { }

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        protected IWebElement BtnCreateAccount = null;

        public void ClickCreateAccountButton()
        {
            BtnCreateAccount.Click();
        }

    }
}
