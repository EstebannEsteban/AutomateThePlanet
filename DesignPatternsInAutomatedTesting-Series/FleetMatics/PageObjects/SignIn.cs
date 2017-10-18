using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FleetMatics.PageObjects
{
    public class SignIn
    {
        IWebDriver _driver;
        
        public SignIn(IWebDriver driver)
        {
           _driver = driver;
           PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        protected IWebElement BtnCreateAccount = null;

        public void ClickCreateAccountButton()
        {
            BtnCreateAccount.Click();
        }

    }
}
