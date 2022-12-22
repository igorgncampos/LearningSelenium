using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.Threading; 

namespace LearningSelenium
{
  [TestClass]
  public class Alerts
  {
    IWebDriver driver;

    [TestMethod]
    public void HandlingAlerts()
    {
      try
      {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://demoqa.com/alerts");
        driver.Manage().Window.Maximize();
        driver.FindElement(By.Id("alertButton")).Click();
        Thread.Sleep(3000);
        IAlert alert = driver.SwitchTo().Alert();
        Debug.WriteLine(alert.Text);
        alert.Accept();
        driver.SwitchTo().DefaultContent();

      }
      catch (Exception e)
      {
        System.Console.WriteLine(e.Message);
        throw;
      }
      finally
      {
        driver.Dispose();
      }
    }


    [TestMethod]
    public void HandlingAlerts2()
    {
      try
      {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://demoqa.com/alerts");
        driver.Manage().Window.Maximize();
        driver.FindElement(By.Id("confirmButton")).Click();
        Thread.Sleep(3000);
        IAlert alert = driver.SwitchTo().Alert();
        Debug.WriteLine(alert.Text);
        alert.Accept();
        Thread.Sleep(5000);
        driver.SwitchTo().DefaultContent();

      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        throw;
      }
      finally
      {
        driver.Dispose();
      }
    }
  }
}
