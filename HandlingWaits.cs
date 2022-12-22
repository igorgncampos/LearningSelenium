using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;

namespace LearningSelenium
{

  [TestClass]
  public class HandlingWaits
  {
    IWebDriver driver;
    [TestMethod]
    public void ImplicitWait()
    {
      try
      {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.google.com/");
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        string waitElement = driver.FindElement(By.Name("q")).Text;
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
        //System.Diagnostics.Debug.WriteLine(e.Message);
        //Console.Read();
      }
      finally
      {
        driver.Dispose();
      }
    }
    [TestMethod]
    public void ExplicitWait()
    {
      try
      {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.google.com/");
        driver.Manage().Window.Maximize();

        IWebElement ele = ExplicitWait(driver,"q");
        if (ExplicitWait(driver, "q") != null)
        {
          string tagNameOfElement = ExplicitWait(driver, "q").Text;
          Assert.IsTrue(true);
        }
      }
      catch (Exception e)
      {
        System.Windows.Forms.MessageBox.Show(e.Message);
        Assert.Fail(e.Message);
      }
      finally
      {
        driver.Quit();
        driver.Dispose();
      }



    }
    public static IWebElement ExplicitWait(IWebDriver driver, string identifier)
    {
      //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
      return new WebDriverWait(driver,TimeSpan.FromSeconds(5)).Until(c => c.FindElement(By.Name(identifier)));
      //c => c.FindElement(By.Id("name")));
    }
  }
}
