using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace MacroManager.Service
{
    public class ExcelService
    {
        public void AddMacro(string path, string macroName)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = false,
                ScreenUpdating = false
            };

            var workbook = excelApp.Workbooks.Open(path + "\\Test.xlsm");

            //var comp = workbook.VBProject.VBComponents.Item("MacroName");

            workbook.Save();
            workbook.Close();
            excelApp.Quit();
        }

        public void CopySheet(string path)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = false,
                ScreenUpdating = false
            };

            var workbook = excelApp.Workbooks.Open(path + "\\Test.xlsm");
            var worksheets = workbook.Worksheets;

            worksheets.get_Item("sheet1").Copy(Type.Missing, worksheets[worksheets.Count]);
            worksheets[worksheets.Count].Name = "NEW SHEET";

            workbook.Save();
            workbook.Close();
            excelApp.Quit();
        }


    }
}
