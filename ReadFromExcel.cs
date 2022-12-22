using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace LearningSelenium
{
  [TestClass]
  public class ReadFromExcel
  {
    [TestMethod]
    public void ReadingDataFromExcel()
    {
      try
      {
        ExcelOperations.PopulateInCollection(@"C:\Users\igorc\Documents\LearningSelenium\LearningSelenium\DBX.xlsx");
        System.Diagnostics.Trace.WriteLine("****************");
        System.Diagnostics.Trace.WriteLine("The person's name is : " + ExcelOperations.ReadData(1,"Pname"));
        System.Diagnostics.Trace.WriteLine("The balance is: " + ExcelOperations.ReadData(1, "Balance"));
        System.Diagnostics.Trace.WriteLine("The Amount is : " + ExcelOperations.ReadData(1, "Amount"));
        System.Diagnostics.Trace.WriteLine("****************");
        System.Diagnostics.Trace.WriteLine("The person's name is  : " + ExcelOperations.ReadData(2, "Pname"));
        System.Diagnostics.Trace.WriteLine("The balance is: " + ExcelOperations.ReadData(2, "Balance"));
        System.Diagnostics.Trace.WriteLine("The Amount is : " + ExcelOperations.ReadData(2, "Amount"));
        System.Diagnostics.Trace.WriteLine("****************");
        System.Diagnostics.Trace.WriteLine("The person's name is  : " + ExcelOperations.ReadData(3, "Pname"));
        System.Diagnostics.Trace.WriteLine("The balance is: " + ExcelOperations.ReadData(3, "Balance"));
        System.Diagnostics.Trace.WriteLine("The Amount is : " + ExcelOperations.ReadData(3, "Amount"));


      }
      catch (Exception e)
      {
        Console.WriteLine (e.Message);
        throw;
      }
    }
  }
}
