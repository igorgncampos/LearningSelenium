using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LearningSelenium
{
  [TestFixture]
  public class NunitInit
  {
    public IWebDriver driver;
    [SetUp]
    public void Init()
    {
      driver = new ChromeDriver();
    }
    [Test]
    public void TestMethod1()
    {
      driver.Navigate().GoToUrl("https://www.google.com/");
      driver.Manage().Window.Maximize();
      Thread.Sleep(5000);
    }
    [TearDown]
    public void TearDown()
    {
      driver.Dispose();
    }
  }
}
