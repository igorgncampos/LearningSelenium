using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningSelenium
{
  [TestClass]
  internal class FacebookLogin
  {
    [TestMethod]
    public void VerifyFacebookLogin()
    {
      IWebDriver driver = new ChromeDriver();
      driver.Navigate().GoToUrl("https://www.facebook.com/");
      driver.Manage().Window.Maximize();
      LoginPage login = new LoginPage(driver);
      login.TypeUserName();
      login.TypePassword();
      login.SendClickLoginbtn();
      Thread.Sleep(2000);
      driver.Dispose();
    }
  }
}
