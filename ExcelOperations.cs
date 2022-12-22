using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Data;
using ExcelDataReader;

namespace LearningSelenium
{
  public class ExcelOperations
  {
    private static DataTable ExceltoDataTable(string filename)
    {
      FileStream stream = File.Open(filename, FileMode.Open, FileAccess.Read);
      IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

      DataSet resultSet = excelReader.AsDataSet(new ExcelDataSetConfiguration()
      {
        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
        {
          UseHeaderRow = true
        }
      });
      DataTableCollection table = resultSet.Tables;
      DataTable resultTable = table["Sheet1"];
      return resultTable;
    }

    public class Datacollection
    {
      public int rowNumber { get; set; }
      public string colName { get; set; }
      public string colValue { get; set; }
    }

    static List<Datacollection> DataCol = new List<Datacollection>();

    public static void PopulateInCollection(string filename)
    {
      DataTable table = ExceltoDataTable(filename);
      for (int row = 1; row <= table.Rows.Count; row++)
      {
        for (int col = 0; col < table.Columns.Count; col++)
        {
          Datacollection dtTable = new Datacollection();
          {

            dtTable.rowNumber = row;
            dtTable.colName = table.Columns[col].ColumnName;
            dtTable.colValue = table.Rows[row - 1][col].ToString();
          };
          DataCol.Add(dtTable);
        }
      }
    }

    public static string ReadData(int rowNumber, string columnName)
    {
      try
      {
        string Data = (from colData in DataCol where colData.colName == columnName && colData.rowNumber == rowNumber select colData.colValue).SingleOrDefault();
        return Data.ToString();
      }
      catch (Exception e)
      {
        return null;
        throw;
      }
    }
  }
}
