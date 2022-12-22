using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSelenium
{
  [TestClass]
  public class FacebookLoginPF
  {
    [TestMethod]
    public void VerifyFacebookLoginPF()
    {
      OpenQA.Selenium.IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
      driver.Navigate().GoToUrl("https://www.facebook.com/");
      driver.Manage().Window.Maximize();
      LoginPagePF loginPagePF = new LoginPagePF();
      SeleniumExtras.PageObjects.PageFactory.InitElements(driver, loginPagePF);
      loginPagePF.username.SendKeys("qwe@qwe.com");
      loginPagePF.password.SendKeys("tyuiolkjhg");
      loginPagePF.ClickLoginBtn();

    }
  }
}
