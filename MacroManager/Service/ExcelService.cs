using System;
using System.Collections.Generic;
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
        }


    }
}
