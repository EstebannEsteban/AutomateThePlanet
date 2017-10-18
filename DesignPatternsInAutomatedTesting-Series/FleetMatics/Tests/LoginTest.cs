using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using FleetMatics.PageObjects;

namespace FleetMatics
{
    public class LoginTest: BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void NavigateMainPageTest()
        {

            MainPage mainPage = Navigate();
            SignIn signIn = mainPage.clickSignInButton();
            signIn.ClickCreateAccountButton();
        }


    }
}
