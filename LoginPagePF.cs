using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSelenium
{
  public class LoginPagePF
  {
    [FindsBy(How = How.Name, Using = "email")] public IWebElement username { get; set; }
    [FindsBy(How =How.Name,Using =  "pass")] public IWebElement password { get; set; }
    [FindsBy(How =How.Name,Using ="login")] public IWebElement login { get; set; }

    public void ClickLoginBtn()
    {
      login.Click();
    }
  }
}
