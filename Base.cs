using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LearningSelenium
{
  [TestFixture]
  public class Base
  {
    public IWebDriver driver;
    [OneTimeSetUp]
    public void Init()
    {
      driver = new ChromeDriver();
    }
    [OneTimeTearDown]
    public void TearDown()
    {
      driver.Dispose();
    }
  }
}
