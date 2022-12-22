using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace LearningSelenium
{


  /*
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void FacebookMethodRadioBtn()
    {
      IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
      driver.Navigate().GoToUrl("https://pt-br.facebook.com/r.php?r=101");
      driver.Manage().Window.Maximize();
      driver.FindElement(By.CssSelector("[id*='u_0_5_']")).Click();
      Thread.Sleep(3000);
      driver.FindElement(By.CssSelector("[id*='u_0_4_']")).Click();
      Thread.Sleep(2000);
      driver.Dispose();
    }
    */
    /*
    [TestMethod]
    public void IronSpiderMethodCheckbox()
    {
      IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
      driver.Navigate().GoToUrl("https://www.ironspider.ca/forms/checkradio.htm");
      driver.Manage().Window.Maximize();
      driver.FindElement(By.XPath("//*[@id=\"Content\"]/div[1]/blockquote[1]/form/input[1]")).Click();
      Thread.Sleep(2000);
      driver.FindElement(By.XPath("//*[@id=\"Content\"]/div[1]/blockquote[1]/form/input[2]")).Click();
    }
    */
    /*
    [TestMethod]
    public void KaggleMethod()
    {
      OpenQA.Selenium.IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
      try
      {
        
        driver.Navigate().GoToUrl("https://www.kaggle.com/account/login?phase=emailSignIn&returnUrl=%2F");
        driver.Manage().Window.Maximize();

        driver.FindElement(By.Name("email")).SendKeys("igorgncampos@gmail.com");
        driver.FindElement(By.Name("password")).SendKeys("255255255");
        driver.FindElement(By.ClassName("sc-gXmSlM")).Click();
        //*[@id="site-container"]/div/div[2]/form/div[2]/div[3]/button/span
      }
      catch (Exception ex) {
        string error = ex.ToString();
        Console.WriteLine(error);
      }
      finally
      {
        Console.WriteLine("close browser");
        ////driver.Dispose();
      }
      Thread.Sleep(10000);

      IWebElement ActionConteiner = driver.FindElement(By.ClassName("km-list"));
      IReadOnlyCollection<IWebElement> KmList = ActionConteiner.FindElements(By.TagName("li"));
      foreach (IWebElement item in KmList)
      {
        string ActionName = item.Text;
        item.Click(); //element not interactible
        Thread.Sleep(5000);
      }


    }
    */
    /*
    [TestMethod]
    public void WikiMethod()
    {
      OpenQA.Selenium.IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
      driver.Navigate().GoToUrl("https://www.wikipedia.org/");
      driver.Manage().Window.Maximize();
      List<string> CentralLanguages = new List<string>();
      System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> Languages =
        driver.FindElements(By.ClassName("central-featured-lang"));

      foreach (var item in Languages)
      {
        string lan = item.Text;
        lan = lan.Substring(0, lan.LastIndexOf('\r'));
        CentralLanguages.Add(lan);
      }
      OpenQA.Selenium.Support.UI.SelectElement selectlanguage = new OpenQA.Selenium.Support.UI.SelectElement(driver.FindElement(By.Id("searchLanguage")));
      selectlanguage.SelectByText("Español");
      selectlanguage.SelectByValue("bg");


      #region MyRegion
      List<string> textofanchors = new List<string>();
      System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> anchorlist = driver.FindElements(By.TagName("a"));
      foreach (var anchor in anchorlist)
      {
        if (anchor.Text.Length > 0)
        {

          textofanchors.Add(anchor.Text);

        }
      }
      System.Diagnostics.Trace.WriteLine(textofanchors);

      driver.FindElement(By.Id("searchInput")).SendKeys("selenium");
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

      driver.FindElement(By.ClassName("svg-search-icon")).Click();

      #endregion
      driver.Quit();
    }
    */
    /*
    [TestMethod]
    public void GoogleMethod()
    {
      string ActualResult;
      string ExpectedResult = "Google";
      OpenQA.Selenium.IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
      driver.Navigate().GoToUrl("https://www.google.com/");
      driver.Manage().Window.Maximize();
      ActualResult = driver.Title;
      if (ActualResult.Contains(ExpectedResult))
      {
        Console.WriteLine("test case passed");
        Assert.IsTrue(true, "test case passed");
      }
      else
        Console.WriteLine("test case failed");
      driver.Close();
      driver.Dispose();
    }
    */
  
}

