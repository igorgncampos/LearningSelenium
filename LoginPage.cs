using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSelenium
{
  internal class LoginPage
  {
    OpenQA.Selenium.WebDriver driver;
    OpenQA.Selenium.By username = OpenQA.Selenium.By.Name("email");
    OpenQA.Selenium.By password = OpenQA.Selenium.By.Name("pass");
    OpenQA.Selenium.By loginbtn = OpenQA.Selenium.By.Name("login");

    public LoginPage(IWebDriver driver)
    {
      this.driver = (WebDriver)driver;
    }

    public void TypeUserName()
    {
      driver.FindElement(username).SendKeys("aec@aec.com");
    }
    public void TypePassword()
    {
      driver.FindElement(password).SendKeys("12345678987654321");
    }

    public void SendClickLoginbtn()
    {
      driver.FindElement(loginbtn).Click();
    }
  }
}
