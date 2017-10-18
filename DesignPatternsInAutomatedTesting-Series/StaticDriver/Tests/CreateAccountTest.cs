using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WebDriverFramework.WebPage;
using StaticDriver.Pages;
using StaticDriver.PageObjects;

namespace StaticDriver.Tests
{
    public class CreateAccountTest:BaseTest<MainPage>
    {

        [Test]
        public void CreateAccount()
        {
            var mainPage = InitialPage;
            var signIn = mainPage.clickSignInButton();
            signIn.ClickCreateAccountButton();
            
        }
    }
}
