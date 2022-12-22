using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace LearningSelenium
{
  public class Util
  {
    public static IWebElement FluentWaitByName(IWebDriver driver, string NameLocator)
    {
      try
      {
        DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
        fluentWait.Timeout = TimeSpan.FromSeconds(15);
        fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
        fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        IWebElement seachElement = fluentWait.Until(x => x.FindElement(By.Name(NameLocator)));
        return seachElement;
      }
      catch (Exception e)
      {
        Debug.WriteLine("some error: " + e.Message);
        //MessageBox.Show(e.Message);
        return null;
      }
      finally
      {

      }
      //return IWebElement("");
    }
  }
}
