//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace LearningSelenium
{
  [TestFixture]
  public class ScreenShot
  {
    IWebDriver driver;
    [Test]
    public void Screen()
    {
      try
      {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.google.com/");
        driver.Manage().Window.Maximize();
        ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("screenshot.png",ScreenshotImageFormat.Png); 
      }
      catch (Exception e)
      {
        Console.WriteLine(e.StackTrace);
        throw;
      }
      finally
      {
        driver.Dispose();
      }
    }
  }
}
