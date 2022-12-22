using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace LearningSelenium
{
  [TestFixture]
  [Parallelizable]
  public class NunitParallelTest : Base
  {
    [Test]
    public void SearchGoogle()
    {
      driver.Navigate().GoToUrl("https://www.google.com/");
      driver.FindElement(By.Name("q")).SendKeys("selenium");
      System.Threading.Thread.Sleep(2000);
      driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
      System.Threading.Thread.Sleep(2000);
    }
  }
  [TestFixture]
  [Parallelizable]
  public class NunitParallelTest2 : Base
  {
    [Test]
    public void SearchGoogle2()
    {
      driver.Navigate().GoToUrl("https://www.google.com/");
      driver.FindElement(By.Name("q")).SendKeys("pokemon");
      System.Threading.Thread.Sleep(2000);
      driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
      System.Threading.Thread.Sleep(2000);

    }
  }
}
